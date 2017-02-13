namespace Musicas.UI.Consultas
{
    partial class ConsultarMusica
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
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewMusicas = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.errorProviderConsulta = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "id",
            "artista",
            "nombre",
            "fecha"});
            this.comboBoxFilter.Location = new System.Drawing.Point(12, 45);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(95, 21);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(113, 46);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(155, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(287, 46);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(55, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewMusicas
            // 
            this.dataGridViewMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusicas.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewMusicas.Name = "dataGridViewMusicas";
            this.dataGridViewMusicas.Size = new System.Drawing.Size(435, 181);
            this.dataGridViewMusicas.TabIndex = 5;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(113, 47);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(83, 20);
            this.dateTimePickerDesde.TabIndex = 3;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(202, 47);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerHasta.TabIndex = 4;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(123, 31);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(38, 13);
            this.labelDesde.TabIndex = 6;
            this.labelDesde.Text = "Desde";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(217, 31);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(35, 13);
            this.labelHasta.TabIndex = 7;
            this.labelHasta.Text = "Hasta";
            // 
            // errorProviderConsulta
            // 
            this.errorProviderConsulta.ContainerControl = this;
            // 
            // ConsultarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 324);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.dataGridViewMusicas);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxFilter);
            this.Name = "ConsultarMusica";
            this.Text = "ConsultarMusica";
            this.Load += new System.EventHandler(this.ConsultarMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewMusicas;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.ErrorProvider errorProviderConsulta;
    }
}