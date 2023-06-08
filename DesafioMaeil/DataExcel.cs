using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace DesafioMaeil
{
    public class DataExcel
    {
        private string csvFile;
        private Log log;
        DataGridView dataGridView;


        /// <summary>
        /// Perform actions in excel file
        /// </summary>
        /// <param name="csvFile"></param>
        public DataExcel(DataGridView dataGridView, string csvFile)
        {
            this.dataGridView = dataGridView;
            this.csvFile = csvFile; 
            log = new Log();
        }

        public List<Row> ConvertDataToList()
        {
            List<Row> gridValues = new List<Row>(); 
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                //Row rowVal = new Row(dt.Rows[0][i++].ToString(), dt.Rows[1][i++].ToString(), dt.Rows[2][i++].ToString(), dt.Rows[3][i++].ToString(), dt.Rows[4][i++].ToString(), dt.Rows[5][i++].ToString(), dt.Rows[6][i++].ToString(), dt.Rows[7][i++].ToString(), dt.Rows[8][i++].ToString(), dt.Rows[9][i++].ToString(), dt.Rows[10][i++].ToString(), dt.Rows[11][i++].ToString(), Convert.ToInt32(dt.Rows[12][i++].ToString()), dt.Rows[13][i++].ToString(), dt.Rows[14][i++].ToString(), dt.Rows[15][i++].ToString(), dt.Rows[16][i++].ToString()); 
                //rowValues.Add(rowVal);
                //row.Cells[""]; insert column name
                //Row rowVal = new Row();

                //gridValues.Add(rowVal);
            }
            return gridValues;
        }


        public DataTable ImportExcel()
        {
            //https://www.youtube.com/watch?v=k44-N4Pegag
            log.Output("A importar o ficheiro excel");

            Cursor.Current = Cursors.WaitCursor;    
            DataTable dt = new DataTable();
            
            using(XLWorkbook wb = new XLWorkbook(csvFile))
            {
                bool isFirtRow = true;
                var rows = wb.Worksheet(1).RowsUsed();
                foreach(var row in rows)
                {
                    if(isFirtRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                            dt.Columns.Add(Convert.ToString(cell.Value.ToString()));
                        isFirtRow = false;
                    }else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach(IXLCell cell in row.Cells(1, dt.Columns.Count)) //add empty cells //https://www.aspsnippets.com/questions/347195/Solved-Empty-cells-skipped-ignored-while-reading-data-from-Excel-to-DataTable-in-ClosedXML/
                        {
                            dt.Rows[dt.Rows.Count - 1][i++] = Convert.ToString(cell.Value.ToString()); // convert to string garantues that the int values is converted to int
                     
                        }
                    }

                }

                dataGridView.DataSource = dt.DefaultView;
                Cursor.Current = Cursors.Default;
            }

            log.Output("Importação concluída");
            return dt;
        }



        public void ExportExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel|*csv" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using(XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dataGridView.ClipboardCopyMode.ToString());
                        wb.SaveAs(sfd.FileName);
                        log.Output($"ficheiro {sfd.FileName} guardado");
                    }

                }
                catch(Exception ex)
                {
                    log.Output(ex.Message); 
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
