namespace WorkersList
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynagrodzenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetWLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetWL = new WorkersList.DataSetWL();
            this.Delete = new System.Windows.Forms.Button();
            this.dataSetWLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imięDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.wiekDataGridViewTextBoxColumn,
            this.wynagrodzenieDataGridViewTextBoxColumn,
            this.stanowiskoDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.iDPracownikaDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.pracownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // imięDataGridViewTextBoxColumn
            // 
            this.imięDataGridViewTextBoxColumn.DataPropertyName = "Imię";
            this.imięDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.imięDataGridViewTextBoxColumn.Name = "imięDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            this.wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            this.wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            this.wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            // 
            // wynagrodzenieDataGridViewTextBoxColumn
            // 
            this.wynagrodzenieDataGridViewTextBoxColumn.DataPropertyName = "Wynagrodzenie";
            this.wynagrodzenieDataGridViewTextBoxColumn.HeaderText = "Wynagrodzenie";
            this.wynagrodzenieDataGridViewTextBoxColumn.Name = "wynagrodzenieDataGridViewTextBoxColumn";
            // 
            // stanowiskoDataGridViewTextBoxColumn
            // 
            this.stanowiskoDataGridViewTextBoxColumn.DataPropertyName = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.Name = "stanowiskoDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // iDPracownikaDataGridViewTextBoxColumn
            // 
            this.iDPracownikaDataGridViewTextBoxColumn.DataPropertyName = "ID_Pracownika";
            this.iDPracownikaDataGridViewTextBoxColumn.HeaderText = "ID_Pracownika";
            this.iDPracownikaDataGridViewTextBoxColumn.Name = "iDPracownikaDataGridViewTextBoxColumn";
            this.iDPracownikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.dataSetWLBindingSource1;
            // 
            // dataSetWLBindingSource1
            // 
            this.dataSetWLBindingSource1.DataSource = this.dataSetWL;
            this.dataSetWLBindingSource1.Position = 0;
            // 
            // dataSetWL
            // 
            this.dataSetWL.DataSetName = "DataSetWL";
            this.dataSetWL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(330, 425);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(243, 28);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Usuń wybrane wiersze";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataSetWLBindingSource
            // 
            this.dataSetWLBindingSource.DataSource = this.dataSetWL;
            this.dataSetWLBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtry bazy pracowników:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista pracowników";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetWLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.BindingSource dataSetWLBindingSource;
        private DataSetWL dataSetWL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wynagrodzenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private System.Windows.Forms.BindingSource dataSetWLBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}

