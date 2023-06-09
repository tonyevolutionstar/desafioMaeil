namespace DesafioMaeil
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.referenciaLbl = new System.Windows.Forms.Label();
            this.referenciaVal = new System.Windows.Forms.TextBox();
            this.estadoVal = new System.Windows.Forms.TextBox();
            this.estadoLbl = new System.Windows.Forms.Label();
            this.tipoVal = new System.Windows.Forms.TextBox();
            this.tipoLbl = new System.Windows.Forms.Label();
            this.matriculaVal = new System.Windows.Forms.TextBox();
            this.matriculaLbl = new System.Windows.Forms.Label();
            this.tipoCargaVal = new System.Windows.Forms.TextBox();
            this.tipoCargaLbl = new System.Windows.Forms.Label();
            this.prioridadeVal = new System.Windows.Forms.TextBox();
            this.prioridadeLbl = new System.Windows.Forms.Label();
            this.dataRegistoVal = new System.Windows.Forms.TextBox();
            this.dataRegistoLbl = new System.Windows.Forms.Label();
            this.blockedTimeLbl = new System.Windows.Forms.Label();
            this.blockedTimeVal = new System.Windows.Forms.TextBox();
            this.podLbl = new System.Windows.Forms.Label();
            this.podVal = new System.Windows.Forms.TextBox();
            this.parqueLbl = new System.Windows.Forms.Label();
            this.parqueVal = new System.Windows.Forms.TextBox();
            this.tipoEquipamentoLbl = new System.Windows.Forms.Label();
            this.tipoEquipVal = new System.Windows.Forms.TextBox();
            this.depositVal = new System.Windows.Forms.TextBox();
            this.depositLbl = new System.Windows.Forms.Label();
            this.dataAtribExpLbl = new System.Windows.Forms.Label();
            this.dataAtribExpVal = new System.Windows.Forms.TextBox();
            this.vesselLbl = new System.Windows.Forms.Label();
            this.vesselVal = new System.Windows.Forms.TextBox();
            this.voyageLbl = new System.Windows.Forms.Label();
            this.voyageVal = new System.Windows.Forms.TextBox();
            this.polLbl = new System.Windows.Forms.Label();
            this.polVal = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clienteLbl = new System.Windows.Forms.Label();
            this.clienteVal = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.rowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoadFileBtn.Location = new System.Drawing.Point(12, 276);
            this.LoadFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(120, 50);
            this.LoadFileBtn.TabIndex = 0;
            this.LoadFileBtn.Text = "Load File";
            this.LoadFileBtn.UseVisualStyleBackColor = false;
            this.LoadFileBtn.Click += new System.EventHandler(this.LoadFile_btn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchBtn.Location = new System.Drawing.Point(331, 276);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(120, 50);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.BackColor = System.Drawing.Color.Yellow;
            this.saveFileBtn.Location = new System.Drawing.Point(170, 276);
            this.saveFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(120, 50);
            this.saveFileBtn.TabIndex = 4;
            this.saveFileBtn.Text = "Save File";
            this.saveFileBtn.UseVisualStyleBackColor = false;
            this.saveFileBtn.Click += new System.EventHandler(this.SaveFile_Btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 336);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1191, 361);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // referenciaLbl
            // 
            this.referenciaLbl.AutoSize = true;
            this.referenciaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.referenciaLbl.Location = new System.Drawing.Point(24, 23);
            this.referenciaLbl.Name = "referenciaLbl";
            this.referenciaLbl.Size = new System.Drawing.Size(95, 20);
            this.referenciaLbl.TabIndex = 6;
            this.referenciaLbl.Text = "Referencia:";
            // 
            // referenciaVal
            // 
            this.referenciaVal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.referenciaVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Referencia", true));
            this.referenciaVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenciaVal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.referenciaVal.Location = new System.Drawing.Point(125, 15);
            this.referenciaVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.referenciaVal.Name = "referenciaVal";
            this.referenciaVal.Size = new System.Drawing.Size(135, 27);
            this.referenciaVal.TabIndex = 7;
            // 
            // estadoVal
            // 
            this.estadoVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Estado", true));
            this.estadoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoVal.Location = new System.Drawing.Point(125, 105);
            this.estadoVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoVal.Name = "estadoVal";
            this.estadoVal.Size = new System.Drawing.Size(135, 27);
            this.estadoVal.TabIndex = 9;
            // 
            // estadoLbl
            // 
            this.estadoLbl.AutoSize = true;
            this.estadoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.estadoLbl.Location = new System.Drawing.Point(53, 112);
            this.estadoLbl.Name = "estadoLbl";
            this.estadoLbl.Size = new System.Drawing.Size(66, 20);
            this.estadoLbl.TabIndex = 8;
            this.estadoLbl.Text = "Estado:";
            // 
            // tipoVal
            // 
            this.tipoVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Tipo", true));
            this.tipoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoVal.Location = new System.Drawing.Point(125, 150);
            this.tipoVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoVal.Name = "tipoVal";
            this.tipoVal.Size = new System.Drawing.Size(135, 27);
            this.tipoVal.TabIndex = 11;
            // 
            // tipoLbl
            // 
            this.tipoLbl.AutoSize = true;
            this.tipoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tipoLbl.Location = new System.Drawing.Point(73, 157);
            this.tipoLbl.Name = "tipoLbl";
            this.tipoLbl.Size = new System.Drawing.Size(46, 20);
            this.tipoLbl.TabIndex = 10;
            this.tipoLbl.Text = "Tipo:";
            // 
            // matriculaVal
            // 
            this.matriculaVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Matricula", true));
            this.matriculaVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaVal.Location = new System.Drawing.Point(416, 15);
            this.matriculaVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matriculaVal.Name = "matriculaVal";
            this.matriculaVal.Size = new System.Drawing.Size(135, 27);
            this.matriculaVal.TabIndex = 13;
            // 
            // matriculaLbl
            // 
            this.matriculaLbl.AutoSize = true;
            this.matriculaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.matriculaLbl.Location = new System.Drawing.Point(327, 23);
            this.matriculaLbl.Name = "matriculaLbl";
            this.matriculaLbl.Size = new System.Drawing.Size(83, 20);
            this.matriculaLbl.TabIndex = 12;
            this.matriculaLbl.Text = "Matricula:";
            // 
            // tipoCargaVal
            // 
            this.tipoCargaVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "TipoCarga", true));
            this.tipoCargaVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCargaVal.Location = new System.Drawing.Point(416, 58);
            this.tipoCargaVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoCargaVal.Name = "tipoCargaVal";
            this.tipoCargaVal.Size = new System.Drawing.Size(135, 27);
            this.tipoCargaVal.TabIndex = 15;
            // 
            // tipoCargaLbl
            // 
            this.tipoCargaLbl.AutoSize = true;
            this.tipoCargaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tipoCargaLbl.Location = new System.Drawing.Point(319, 65);
            this.tipoCargaLbl.Name = "tipoCargaLbl";
            this.tipoCargaLbl.Size = new System.Drawing.Size(91, 20);
            this.tipoCargaLbl.TabIndex = 14;
            this.tipoCargaLbl.Text = "TipoCarga:";
            // 
            // prioridadeVal
            // 
            this.prioridadeVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Prioridade", true));
            this.prioridadeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioridadeVal.Location = new System.Drawing.Point(415, 105);
            this.prioridadeVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prioridadeVal.Name = "prioridadeVal";
            this.prioridadeVal.Size = new System.Drawing.Size(135, 27);
            this.prioridadeVal.TabIndex = 17;
            // 
            // prioridadeLbl
            // 
            this.prioridadeLbl.AutoSize = true;
            this.prioridadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.prioridadeLbl.Location = new System.Drawing.Point(319, 108);
            this.prioridadeLbl.Name = "prioridadeLbl";
            this.prioridadeLbl.Size = new System.Drawing.Size(90, 20);
            this.prioridadeLbl.TabIndex = 16;
            this.prioridadeLbl.Text = "Prioridade:";
            // 
            // dataRegistoVal
            // 
            this.dataRegistoVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "DataRegisto", true));
            this.dataRegistoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRegistoVal.Location = new System.Drawing.Point(416, 157);
            this.dataRegistoVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRegistoVal.Name = "dataRegistoVal";
            this.dataRegistoVal.Size = new System.Drawing.Size(135, 27);
            this.dataRegistoVal.TabIndex = 19;
            // 
            // dataRegistoLbl
            // 
            this.dataRegistoLbl.AutoSize = true;
            this.dataRegistoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dataRegistoLbl.Location = new System.Drawing.Point(303, 157);
            this.dataRegistoLbl.Name = "dataRegistoLbl";
            this.dataRegistoLbl.Size = new System.Drawing.Size(107, 20);
            this.dataRegistoLbl.TabIndex = 18;
            this.dataRegistoLbl.Text = "DataRegisto:";
            // 
            // blockedTimeLbl
            // 
            this.blockedTimeLbl.AutoSize = true;
            this.blockedTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.blockedTimeLbl.Location = new System.Drawing.Point(599, 23);
            this.blockedTimeLbl.Name = "blockedTimeLbl";
            this.blockedTimeLbl.Size = new System.Drawing.Size(111, 20);
            this.blockedTimeLbl.TabIndex = 18;
            this.blockedTimeLbl.Text = "BlockedTime:";
            // 
            // blockedTimeVal
            // 
            this.blockedTimeVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "BlockedTime", true));
            this.blockedTimeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedTimeVal.Location = new System.Drawing.Point(716, 17);
            this.blockedTimeVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockedTimeVal.Name = "blockedTimeVal";
            this.blockedTimeVal.Size = new System.Drawing.Size(135, 27);
            this.blockedTimeVal.TabIndex = 19;
            // 
            // podLbl
            // 
            this.podLbl.AutoSize = true;
            this.podLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.podLbl.Location = new System.Drawing.Point(659, 72);
            this.podLbl.Name = "podLbl";
            this.podLbl.Size = new System.Drawing.Size(51, 20);
            this.podLbl.TabIndex = 18;
            this.podLbl.Text = "POD:";
            // 
            // podVal
            // 
            this.podVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Pod", true));
            this.podVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podVal.Location = new System.Drawing.Point(716, 65);
            this.podVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.podVal.Name = "podVal";
            this.podVal.Size = new System.Drawing.Size(135, 27);
            this.podVal.TabIndex = 19;
            // 
            // parqueLbl
            // 
            this.parqueLbl.AutoSize = true;
            this.parqueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.parqueLbl.Location = new System.Drawing.Point(643, 112);
            this.parqueLbl.Name = "parqueLbl";
            this.parqueLbl.Size = new System.Drawing.Size(67, 20);
            this.parqueLbl.TabIndex = 18;
            this.parqueLbl.Text = "Parque:";
            // 
            // parqueVal
            // 
            this.parqueVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Parque", true));
            this.parqueVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parqueVal.Location = new System.Drawing.Point(716, 105);
            this.parqueVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parqueVal.Name = "parqueVal";
            this.parqueVal.Size = new System.Drawing.Size(135, 27);
            this.parqueVal.TabIndex = 19;
            // 
            // tipoEquipamentoLbl
            // 
            this.tipoEquipamentoLbl.AutoSize = true;
            this.tipoEquipamentoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tipoEquipamentoLbl.Location = new System.Drawing.Point(599, 144);
            this.tipoEquipamentoLbl.Name = "tipoEquipamentoLbl";
            this.tipoEquipamentoLbl.Size = new System.Drawing.Size(111, 40);
            this.tipoEquipamentoLbl.TabIndex = 18;
            this.tipoEquipamentoLbl.Text = "Tipo\nEquipamento:";
            // 
            // tipoEquipVal
            // 
            this.tipoEquipVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "TipoEquipamento", true));
            this.tipoEquipVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoEquipVal.Location = new System.Drawing.Point(716, 157);
            this.tipoEquipVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoEquipVal.Name = "tipoEquipVal";
            this.tipoEquipVal.Size = new System.Drawing.Size(135, 27);
            this.tipoEquipVal.TabIndex = 19;
            // 
            // depositVal
            // 
            this.depositVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositVal.Location = new System.Drawing.Point(1038, 33);
            this.depositVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositVal.Name = "depositVal";
            this.depositVal.Size = new System.Drawing.Size(135, 27);
            this.depositVal.TabIndex = 21;
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.depositLbl.Location = new System.Drawing.Point(954, 18);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(78, 40);
            this.depositLbl.TabIndex = 20;
            this.depositLbl.Text = "DepotId\nBlocking:";
            // 
            // dataAtribExpLbl
            // 
            this.dataAtribExpLbl.AutoSize = true;
            this.dataAtribExpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dataAtribExpLbl.Location = new System.Drawing.Point(919, 86);
            this.dataAtribExpLbl.Name = "dataAtribExpLbl";
            this.dataAtribExpLbl.Size = new System.Drawing.Size(113, 20);
            this.dataAtribExpLbl.TabIndex = 20;
            this.dataAtribExpLbl.Text = "DataAtribExp:";
            // 
            // dataAtribExpVal
            // 
            this.dataAtribExpVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "DataAtribExp", true));
            this.dataAtribExpVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAtribExpVal.Location = new System.Drawing.Point(1040, 79);
            this.dataAtribExpVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataAtribExpVal.Name = "dataAtribExpVal";
            this.dataAtribExpVal.Size = new System.Drawing.Size(131, 27);
            this.dataAtribExpVal.TabIndex = 21;
            // 
            // vesselLbl
            // 
            this.vesselLbl.AutoSize = true;
            this.vesselLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.vesselLbl.Location = new System.Drawing.Point(969, 136);
            this.vesselLbl.Name = "vesselLbl";
            this.vesselLbl.Size = new System.Drawing.Size(65, 20);
            this.vesselLbl.TabIndex = 20;
            this.vesselLbl.Text = "Vessel:";
            // 
            // vesselVal
            // 
            this.vesselVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Vessel", true));
            this.vesselVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vesselVal.Location = new System.Drawing.Point(1040, 133);
            this.vesselVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vesselVal.Name = "vesselVal";
            this.vesselVal.Size = new System.Drawing.Size(129, 27);
            this.vesselVal.TabIndex = 21;
            // 
            // voyageLbl
            // 
            this.voyageLbl.AutoSize = true;
            this.voyageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.voyageLbl.Location = new System.Drawing.Point(963, 190);
            this.voyageLbl.Name = "voyageLbl";
            this.voyageLbl.Size = new System.Drawing.Size(69, 20);
            this.voyageLbl.TabIndex = 20;
            this.voyageLbl.Text = "Voyage:";
            // 
            // voyageVal
            // 
            this.voyageVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Voyage", true));
            this.voyageVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voyageVal.Location = new System.Drawing.Point(1038, 187);
            this.voyageVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voyageVal.Name = "voyageVal";
            this.voyageVal.Size = new System.Drawing.Size(129, 27);
            this.voyageVal.TabIndex = 21;
            // 
            // polLbl
            // 
            this.polLbl.AutoSize = true;
            this.polLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.polLbl.Location = new System.Drawing.Point(978, 235);
            this.polLbl.Name = "polLbl";
            this.polLbl.Size = new System.Drawing.Size(48, 20);
            this.polLbl.TabIndex = 20;
            this.polLbl.Text = "POL:";
            // 
            // polVal
            // 
            this.polVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Pol", true));
            this.polVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polVal.Location = new System.Drawing.Point(1038, 228);
            this.polVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polVal.Name = "polVal";
            this.polVal.Size = new System.Drawing.Size(129, 27);
            this.polVal.TabIndex = 21;
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.insertBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insertBtn.Location = new System.Drawing.Point(696, 276);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(120, 50);
            this.insertBtn.TabIndex = 22;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Yellow;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Location = new System.Drawing.Point(855, 276);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 50);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.clienteLbl.Location = new System.Drawing.Point(53, 64);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(66, 20);
            this.clienteLbl.TabIndex = 6;
            this.clienteLbl.Text = "Cliente:";
            // 
            // clienteVal
            // 
            this.clienteVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rowBindingSource, "Cliente", true));
            this.clienteVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteVal.Location = new System.Drawing.Point(125, 61);
            this.clienteVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clienteVal.Name = "clienteVal";
            this.clienteVal.Size = new System.Drawing.Size(135, 27);
            this.clienteVal.TabIndex = 7;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(504, 276);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(120, 50);
            this.resetBtn.TabIndex = 23;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteBtn.Location = new System.Drawing.Point(1011, 276);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 50);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete ";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // rowBindingSource
            // 
            this.rowBindingSource.DataSource = typeof(DesafioMaeil.Row);
            // 
            // listaBindingSource
            // 
            this.listaBindingSource.DataSource = typeof(DesafioMaeil.Lista);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 708);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.polVal);
            this.Controls.Add(this.voyageVal);
            this.Controls.Add(this.vesselVal);
            this.Controls.Add(this.polLbl);
            this.Controls.Add(this.dataAtribExpVal);
            this.Controls.Add(this.voyageLbl);
            this.Controls.Add(this.depositVal);
            this.Controls.Add(this.vesselLbl);
            this.Controls.Add(this.dataAtribExpLbl);
            this.Controls.Add(this.depositLbl);
            this.Controls.Add(this.tipoEquipVal);
            this.Controls.Add(this.parqueVal);
            this.Controls.Add(this.podVal);
            this.Controls.Add(this.blockedTimeVal);
            this.Controls.Add(this.dataRegistoVal);
            this.Controls.Add(this.tipoEquipamentoLbl);
            this.Controls.Add(this.parqueLbl);
            this.Controls.Add(this.podLbl);
            this.Controls.Add(this.blockedTimeLbl);
            this.Controls.Add(this.dataRegistoLbl);
            this.Controls.Add(this.prioridadeVal);
            this.Controls.Add(this.prioridadeLbl);
            this.Controls.Add(this.tipoCargaVal);
            this.Controls.Add(this.tipoCargaLbl);
            this.Controls.Add(this.matriculaVal);
            this.Controls.Add(this.matriculaLbl);
            this.Controls.Add(this.tipoVal);
            this.Controls.Add(this.tipoLbl);
            this.Controls.Add(this.estadoVal);
            this.Controls.Add(this.estadoLbl);
            this.Controls.Add(this.clienteVal);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.referenciaVal);
            this.Controls.Add(this.referenciaLbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.LoadFileBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "DesafioMaeil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.BindingSource rowBindingSource;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label referenciaLbl;
        private System.Windows.Forms.TextBox referenciaVal;
        private System.Windows.Forms.TextBox estadoVal;
        private System.Windows.Forms.Label estadoLbl;
        private System.Windows.Forms.TextBox tipoVal;
        private System.Windows.Forms.Label tipoLbl;
        private System.Windows.Forms.TextBox matriculaVal;
        private System.Windows.Forms.Label matriculaLbl;
        private System.Windows.Forms.TextBox tipoCargaVal;
        private System.Windows.Forms.Label tipoCargaLbl;
        private System.Windows.Forms.TextBox prioridadeVal;
        private System.Windows.Forms.Label prioridadeLbl;
        private System.Windows.Forms.TextBox dataRegistoVal;
        private System.Windows.Forms.Label dataRegistoLbl;
        private System.Windows.Forms.Label blockedTimeLbl;
        private System.Windows.Forms.TextBox blockedTimeVal;
        private System.Windows.Forms.Label podLbl;
        private System.Windows.Forms.TextBox podVal;
        private System.Windows.Forms.Label parqueLbl;
        private System.Windows.Forms.TextBox parqueVal;
        private System.Windows.Forms.Label tipoEquipamentoLbl;
        private System.Windows.Forms.TextBox tipoEquipVal;
        private System.Windows.Forms.TextBox depositVal;
        private System.Windows.Forms.Label depositLbl;
        private System.Windows.Forms.Label dataAtribExpLbl;
        private System.Windows.Forms.TextBox dataAtribExpVal;
        private System.Windows.Forms.Label vesselLbl;
        private System.Windows.Forms.TextBox vesselVal;
        private System.Windows.Forms.Label voyageLbl;
        private System.Windows.Forms.TextBox voyageVal;
        private System.Windows.Forms.Label polLbl;
        private System.Windows.Forms.TextBox polVal;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.TextBox clienteVal;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource listaBindingSource;
    }
}

