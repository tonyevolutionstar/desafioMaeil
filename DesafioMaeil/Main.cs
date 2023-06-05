using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioMaeil
{
    public partial class Main : Form
    {
        private string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private string csvFile;
        public Log log;

        private readonly string errorFileSelect = "Error, no selected file";

        public Main()
        {
            InitializeComponent();
            log = new Log();
        }

        /// <summary>
        /// Obtain Name File without Path
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            string[] values = csvFile.Split(new[] { "\\" }, StringSplitOptions.None);
            return values[values.Length - 1];
        }

        public bool Choose_file()
        {
            string currentDirectory = System.IO.Path.GetDirectoryName(assemblyPath);
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel|*csv" , Multiselect = false};
            ofd.InitialDirectory = currentDirectory;
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                csvFile = ofd.FileName;
                return true;
            }
            else if (result == DialogResult.Cancel)
                return false;
            return true;
        }

        private void LoadFile_btn_Click(object sender, EventArgs e)
        {
            if(Choose_file())
            {
                string nameFile = GetName();
                log.Output($"Foi escolhido o ficheiro {nameFile} para leitura");
                DataExcel dataExcel = new DataExcel(dataGridView, csvFile);
                dataExcel.ImportExcel();
            }else
            {
                MessageBox.Show(errorFileSelect);
                log.Output(errorFileSelect);
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView.DataSource as DataView;
                if (dv != null)
                    dv.RowFilter = refSearch.Text;

            }catch (Exception ex)
            {
                log.Output(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveFile_Btn_Click(object sender, EventArgs e)
        {
            DataExcel dataExcel = new DataExcel(dataGridView, csvFile);
            dataExcel.ExportExcel();
        }

    }
}
