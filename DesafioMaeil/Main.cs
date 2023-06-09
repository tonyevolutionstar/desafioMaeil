using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DesafioMaeil
{
    public partial class Main : Form
    {
        private string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private string csvFile;
        public Log log;

        private Lista listaClass;
        private DataTable dt;

        private readonly string errorFileSelect = "Error, no selected file";
        bool insertFlag = false;
        bool updateFlag = false;
        bool deleteFlag = false;

        public Main()
        {
            InitializeComponent();
            log = new Log();
            listaClass = new Lista();
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
                log.Output($"File {nameFile} choosed for reading");
                DataExcel dataExcel = new DataExcel(dataGridView, csvFile);
                dt = dataExcel.ImportExcel();
               
                listaClass.listaRow = dataExcel.ConvertDataToList();
            }
            else
            {
                MessageBox.Show(errorFileSelect);
                log.Output(errorFileSelect);
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            log.Output($"Searching for a reference: {referenciaVal.Text}");

            if(String.IsNullOrEmpty(referenciaVal.Text))
            {
                log.Output("Reference it is required to search");
                MessageBox.Show("Reference it is required to search");
            }
            else
            {
                List<Row> lSearch = listaClass.Search(referenciaVal.Text);
                if(lSearch.Count == 0)
                {
                    log.Output("Reference not found");
                    MessageBox.Show("Reference not found");
                }
                else
                {
                    dataGridView.DataSource = lSearch;
                    log.Output($"Found {lSearch.Count} references for {referenciaVal.Text}");
                }
            }
        }

        private void SaveFile_Btn_Click(object sender, EventArgs e)
        {
            DataExcel dataExcel = new DataExcel(dataGridView, csvFile);
            dataExcel.ExportExcel(listaClass.listaRow);
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Row rowVal = new Row(referenciaVal.Text, clienteVal.Text, estadoVal.Text, tipoVal.Text, matriculaVal.Text, tipoCargaVal.Text, prioridadeVal.Text, dataRegistoVal.Text, blockedTimeVal.Text, podVal.Text, parqueVal.Text, tipoEquipVal.Text, depositVal.Text, dataAtribExpVal.Text, vesselVal.Text, voyageVal.Text, polVal.Text);
            listaClass.Insert(rowVal);
            log.Output($"inserted value referencia: {rowVal.Referencia} | cliente: {rowVal.Cliente} | estado: {rowVal.Estado} | tipo: {rowVal.Tipo} | matricula: {rowVal.Matricula}" +
            $" | tipoCarga: {rowVal.TipoCarga} | prioridade: {rowVal.Prioridade} | dataRegisto: {rowVal.DataRegisto} | blockedTime: {rowVal.BlockedTime} " +
            $"| pod: {rowVal.Pod} | parque: {rowVal.Parque} | tipoEquipamento: {rowVal.TipoEquipamento} | DepotIdBlocking: {rowVal.DepotIdBlocking} | " +
            $" dataAtribExp: {rowVal.DataAtribExp} | vessel: {rowVal.Vessel} | voyage: {rowVal.Voyage} | pol: {rowVal.Pol}");
            //dataGridView.DataSource = listaClass.listaRow;
            MessageBox.Show("Inserted Value");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Row newRow = new Row(referenciaVal.Text, clienteVal.Text, estadoVal.Text, tipoVal.Text, matriculaVal.Text, tipoCargaVal.Text, prioridadeVal.Text, dataRegistoVal.Text, blockedTimeVal.Text, podVal.Text, parqueVal.Text, tipoEquipVal.Text, depositVal.Text, dataAtribExpVal.Text, vesselVal.Text, voyageVal.Text, polVal.Text);
            Row oldRow = new Row(dataGridView.SelectedRows[0].Cells[0].Value.ToString(), dataGridView.SelectedRows[0].Cells[1].Value.ToString(), dataGridView.SelectedRows[0].Cells[2].Value.ToString(), dataGridView.SelectedRows[0].Cells[3].Value.ToString(), dataGridView.SelectedRows[0].Cells[4].Value.ToString(), dataGridView.SelectedRows[0].Cells[5].Value.ToString(), dataGridView.SelectedRows[0].Cells[6].Value.ToString(), dataGridView.SelectedRows[0].Cells[7].Value.ToString(), dataGridView.SelectedRows[0].Cells[8].Value.ToString(), dataGridView.SelectedRows[0].Cells[9].Value.ToString(), dataGridView.SelectedRows[0].Cells[10].Value.ToString(), dataGridView.SelectedRows[0].Cells[11].Value.ToString(), dataGridView.SelectedRows[0].Cells[12].Value.ToString(), dataGridView.SelectedRows[0].Cells[13].Value.ToString(), dataGridView.SelectedRows[0].Cells[14].Value.ToString(), dataGridView.SelectedRows[0].Cells[15].Value.ToString(), dataGridView.SelectedRows[0].Cells[16].Value.ToString());
            listaClass.Update(oldRow, newRow);
            log.Output($"updated value referencia: {oldRow.Referencia} | cliente: {oldRow.Cliente} | estado: {oldRow.Estado} | tipo: {oldRow.Tipo} | matricula: {oldRow.Matricula}" +
                $" | tipoCarga: {oldRow.TipoCarga} | prioridade: {oldRow.Prioridade} | dataRegisto: {oldRow.DataRegisto} | blockedTime: {oldRow.BlockedTime} " +
                $"| pod: {oldRow.Pod} | parque: {oldRow.Parque} | tipoEquipamento: {oldRow.TipoEquipamento} | DepotIdBlocking: {oldRow.DepotIdBlocking} | " +
                $" dataAtribExp: {oldRow.DataAtribExp} | vessel: {oldRow.Vessel} | voyage: {oldRow.Voyage} | pol: {oldRow.Pol}" + " \n to \n" +
                $" referencia: {newRow.Referencia} | cliente: {newRow.Cliente} | estado: {newRow.Estado} | tipo: {newRow.Tipo} | matricula: {newRow.Matricula}" +
                $" | tipoCarga: {newRow.TipoCarga} | prioridade: {newRow.Prioridade} | dataRegisto: {newRow.DataRegisto} | blockedTime: {newRow.BlockedTime} " +
                $"| pod: {newRow.Pod} | parque: {newRow.Parque} | tipoEquipamento: {newRow.TipoEquipamento} | DepotIdBlocking: {newRow.DepotIdBlocking} | " +
                $" dataAtribExp: {newRow.DataAtribExp} | vessel: {newRow.Vessel} | voyage: {newRow.Voyage} | pol: {newRow.Pol}");
            //dataGridView.DataSource = listaClass.listaRow;
            MessageBox.Show("Updated Value");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Row delRow = new Row(referenciaVal.Text, clienteVal.Text, estadoVal.Text, tipoVal.Text, matriculaVal.Text, tipoCargaVal.Text, prioridadeVal.Text, dataRegistoVal.Text, blockedTimeVal.Text, podVal.Text, parqueVal.Text, tipoEquipVal.Text, depositVal.Text, dataAtribExpVal.Text, vesselVal.Text, voyageVal.Text, polVal.Text);
            listaClass.Delete(delRow);
            log.Output($"deleted value referencia: {delRow.Referencia} | cliente: {delRow.Cliente} | estado: {delRow.Estado} | tipo: {delRow.Tipo} | matricula: {delRow.Matricula}" +
            $" | tipoCarga: {delRow.TipoCarga} | prioridade: {delRow.Prioridade} | dataRegisto: {delRow.DataRegisto} | blockedTime: {delRow.BlockedTime} " +
            $"| pod: {delRow.Pod} | parque: {delRow.Parque} | tipoEquipamento: {delRow.TipoEquipamento} | DepotIdBlocking: {delRow.DepotIdBlocking} | " +
            $" dataAtribExp: {delRow.DataAtribExp} | vessel: {delRow.Vessel} | voyage: {delRow.Voyage} | pol: {delRow.Pol}");
            //dataGridView.DataSource = listaClass.listaRow;
            MessageBox.Show("Deleted Value");

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            dataGridView.DataSource = listaClass.listaRow;
        }

        private void ClearTextBox()
        {
            referenciaVal.Text = "";
            clienteVal.Text = "";
            estadoVal.Text = "";
            tipoVal.Text = "";
            matriculaVal.Text = "";
            tipoCargaVal.Text = "";
            prioridadeVal.Text = "";
            dataRegistoVal.Text = "";
            blockedTimeVal.Text = "";
            podVal.Text = "";
            parqueVal.Text = "";
            tipoEquipVal.Text = "";
            depositVal.Text = "";
            dataAtribExpVal.Text = "";
            vesselVal.Text = "";
            voyageVal.Text = "";
            polVal.Text = "";
        }


        private void VerifyNull()
        {
            log.Output("Verifying null values on datagridview");
            if (dataGridView.SelectedRows[0].Cells[0].Value == null)
                dataGridView.SelectedRows[0].Cells[0].Value = "";
            if (dataGridView.SelectedRows[0].Cells[1].Value == null)
                dataGridView.SelectedRows[0].Cells[1].Value = "";
            if (dataGridView.SelectedRows[0].Cells[2].Value == null)
                dataGridView.SelectedRows[0].Cells[2].Value = "";
            if (dataGridView.SelectedRows[0].Cells[3].Value == null)
                dataGridView.SelectedRows[0].Cells[3].Value = "";
            if (dataGridView.SelectedRows[0].Cells[4].Value == null)
                dataGridView.SelectedRows[0].Cells[4].Value = "";
            if (dataGridView.SelectedRows[0].Cells[5].Value == null)
                dataGridView.SelectedRows[0].Cells[5].Value = "";
            if (dataGridView.SelectedRows[0].Cells[6].Value == null)
                dataGridView.SelectedRows[0].Cells[6].Value = "";
            if (dataGridView.SelectedRows[0].Cells[7].Value == null)
                dataGridView.SelectedRows[0].Cells[7].Value = "";
            if (dataGridView.SelectedRows[0].Cells[8].Value == null)
                dataGridView.SelectedRows[0].Cells[8].Value = "";
            if (dataGridView.SelectedRows[0].Cells[9].Value == null)
                dataGridView.SelectedRows[0].Cells[9].Value = "";
            if (dataGridView.SelectedRows[0].Cells[10].Value == null)
                dataGridView.SelectedRows[0].Cells[10].Value = "";
            if (dataGridView.SelectedRows[0].Cells[11].Value == null)
                dataGridView.SelectedRows[0].Cells[11].Value = "";
            if (dataGridView.SelectedRows[0].Cells[12].Value == null)
                dataGridView.SelectedRows[0].Cells[12].Value = "";
            if (dataGridView.SelectedRows[0].Cells[13].Value == null)
                dataGridView.SelectedRows[0].Cells[13].Value = "";
            if (dataGridView.SelectedRows[0].Cells[14].Value == null)
                dataGridView.SelectedRows[0].Cells[14].Value = "";
            if (dataGridView.SelectedRows[0].Cells[15].Value == null)
                dataGridView.SelectedRows[0].Cells[15].Value = "";
            if (dataGridView.SelectedRows[0].Cells[16].Value == null)
                dataGridView.SelectedRows[0].Cells[16].Value = "";
            log.Output("Null values verified");
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)  //https://www.youtube.com/watch?v=C3E1fsXpGRs
        {
            VerifyNull();
       
            referenciaVal.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            clienteVal.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            estadoVal.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            tipoVal.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            matriculaVal.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            tipoCargaVal.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            prioridadeVal.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
            dataRegistoVal.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
            blockedTimeVal.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
            podVal.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
            parqueVal.Text = dataGridView.SelectedRows[0].Cells[10].Value.ToString();
            tipoEquipVal.Text = dataGridView.SelectedRows[0].Cells[11].Value.ToString();
            depositVal.Text = dataGridView.SelectedRows[0].Cells[12].Value.ToString();
            dataAtribExpVal.Text = dataGridView.SelectedRows[0].Cells[13].Value.ToString();
            vesselVal.Text = dataGridView.SelectedRows[0].Cells[14].Value.ToString();
            voyageVal.Text = dataGridView.SelectedRows[0].Cells[15].Value.ToString();
            polVal.Text = dataGridView.SelectedRows[0].Cells[16].Value.ToString();
        }
    }
}
