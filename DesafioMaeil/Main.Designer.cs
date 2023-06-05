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
            this.LoadFile_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SaveFile_Btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFile_btn
            // 
            this.LoadFile_btn.Location = new System.Drawing.Point(12, 12);
            this.LoadFile_btn.Name = "LoadFile_btn";
            this.LoadFile_btn.Size = new System.Drawing.Size(109, 39);
            this.LoadFile_btn.TabIndex = 0;
            this.LoadFile_btn.Text = "Load File";
            this.LoadFile_btn.UseVisualStyleBackColor = true;
            this.LoadFile_btn.Click += new System.EventHandler(this.LoadFile_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // refSearch
            // 
            this.refSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refSearch.Location = new System.Drawing.Point(268, 17);
            this.refSearch.Name = "refSearch";
            this.refSearch.Size = new System.Drawing.Size(268, 27);
            this.refSearch.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(559, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(115, 39);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SaveFile_Btn
            // 
            this.SaveFile_Btn.Location = new System.Drawing.Point(737, 12);
            this.SaveFile_Btn.Name = "SaveFile_Btn";
            this.SaveFile_Btn.Size = new System.Drawing.Size(128, 39);
            this.SaveFile_Btn.TabIndex = 4;
            this.SaveFile_Btn.Text = "SaveFile";
            this.SaveFile_Btn.UseVisualStyleBackColor = true;
            this.SaveFile_Btn.Click += new System.EventHandler(this.SaveFile_Btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1419, 520);
            this.dataGridView.TabIndex = 5;
            // 
            // rowBindingSource
            // 
            this.rowBindingSource.DataSource = typeof(DesafioMaeil.Row);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 591);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SaveFile_Btn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.refSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadFile_btn);
            this.Name = "Main";
            this.Text = "DesafioMaeil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFile_btn;
        private System.Windows.Forms.BindingSource rowBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox refSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button SaveFile_Btn;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

