using System;
using System.Collections.Generic;
using System.Data;

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

        private void VerifyNull(DataGridViewRow row)
        {
            if (row.Cells[0].Value == null)
                row.Cells[0].Value = "";
            if (row.Cells[1].Value == null)
                row.Cells[1].Value = "";
            if (row.Cells[2].Value == null)
                row.Cells[2].Value = "";
            if (row.Cells[3].Value == null)
                row.Cells[3].Value = "";
            if (row.Cells[4].Value == null)
                row.Cells[4].Value = "";
            if (row.Cells[5].Value == null)
                row.Cells[5].Value = "";
            if (row.Cells[6].Value == null)
                row.Cells[6].Value = "";
            if (row.Cells[7].Value == null)
                row.Cells[7].Value = "";
            if (row.Cells[8].Value == null)
                row.Cells[8].Value = "";
            if (row.Cells[9].Value == null)
                row.Cells[9].Value = "";
            if (row.Cells[10].Value == null)
                row.Cells[10].Value = "";
            if (row.Cells[11].Value == null)
                row.Cells[11].Value = "";
            if (row.Cells[12].Value == null)
                row.Cells[12].Value = "";
            if (row.Cells[13].Value == null)
                row.Cells[13].Value = "";
            if (row.Cells[14].Value == null)
                row.Cells[14].Value = "";
            if (row.Cells[15].Value == null)
                row.Cells[15].Value = "";
            if (row.Cells[16].Value == null)
                row.Cells[16].Value = "";
        }

        /// <summary>
        /// create list of rows for manipulation
        /// </summary>
        /// <returns></returns>
        public List<Row> ConvertDataToList()
        {
            List<Row> gridValues = new List<Row>();
        
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                VerifyNull(row);
                Row rowVal = new Row(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(), row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString());
                gridValues.Add(rowVal);
            }
            return gridValues;
        }


        public DataTable ImportExcel()
        {
            //https://www.youtube.com/watch?v=k44-N4Pegag
            log.Output("Importing excel file");

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
                            dt.Rows[dt.Rows.Count - 1][i++] = Convert.ToString(cell.Value.ToString()); // convert to string garantues that the int values is converted to string
                        }
                    }
                }
                dataGridView.DataSource = dt.DefaultView;
                Cursor.Current = Cursors.Default;
            }

            log.Output("Importation concluded");
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
                        log.Output($"file {sfd.FileName} saved");
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
