namespace Transporte
{
    partial class frmAutobus
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label n__AcientosLabel;
            System.Windows.Forms.Label año_de_FabricaciónLabel;
            System.Windows.Forms.Label kmLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lineaTransportesDataSet = new Transporte.LineaTransportesDataSet();
            this.autobusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusTableAdapter = new Transporte.LineaTransportesDataSetTableAdapters.AutobusTableAdapter();
            this.tableAdapterManager = new Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager();
            this.autobusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.n__AcientosTextBox = new System.Windows.Forms.TextBox();
            this.año_de_FabricaciónTextBox = new System.Windows.Forms.TextBox();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            n__AcientosLabel = new System.Windows.Forms.Label();
            año_de_FabricaciónLabel = new System.Windows.Forms.Label();
            kmLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Cyan;
            codigoLabel.ForeColor = System.Drawing.Color.Black;
            codigoLabel.Location = new System.Drawing.Point(11, 21);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Cyan;
            tipoLabel.ForeColor = System.Drawing.Color.Black;
            tipoLabel.Location = new System.Drawing.Point(11, 47);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 2;
            tipoLabel.Text = "Tipo:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.BackColor = System.Drawing.Color.Cyan;
            marcaLabel.ForeColor = System.Drawing.Color.Black;
            marcaLabel.Location = new System.Drawing.Point(11, 73);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 4;
            marcaLabel.Text = "Marca:";
            // 
            // n__AcientosLabel
            // 
            n__AcientosLabel.AutoSize = true;
            n__AcientosLabel.BackColor = System.Drawing.Color.Cyan;
            n__AcientosLabel.ForeColor = System.Drawing.Color.Black;
            n__AcientosLabel.Location = new System.Drawing.Point(11, 99);
            n__AcientosLabel.Name = "n__AcientosLabel";
            n__AcientosLabel.Size = new System.Drawing.Size(69, 13);
            n__AcientosLabel.TabIndex = 6;
            n__AcientosLabel.Text = "N# Acientos:";
            // 
            // año_de_FabricaciónLabel
            // 
            año_de_FabricaciónLabel.AutoSize = true;
            año_de_FabricaciónLabel.BackColor = System.Drawing.Color.Cyan;
            año_de_FabricaciónLabel.ForeColor = System.Drawing.Color.Black;
            año_de_FabricaciónLabel.Location = new System.Drawing.Point(11, 125);
            año_de_FabricaciónLabel.Name = "año_de_FabricaciónLabel";
            año_de_FabricaciónLabel.Size = new System.Drawing.Size(102, 13);
            año_de_FabricaciónLabel.TabIndex = 8;
            año_de_FabricaciónLabel.Text = "Año de Fabricación:";
            // 
            // kmLabel
            // 
            kmLabel.AutoSize = true;
            kmLabel.BackColor = System.Drawing.Color.Cyan;
            kmLabel.ForeColor = System.Drawing.Color.Black;
            kmLabel.Location = new System.Drawing.Point(11, 151);
            kmLabel.Name = "kmLabel";
            kmLabel.Size = new System.Drawing.Size(25, 13);
            kmLabel.TabIndex = 10;
            kmLabel.Text = "Km:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Lime;
            this.BtnSalir.Location = new System.Drawing.Point(528, 60);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 30;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Lime;
            this.btnCancelar.Location = new System.Drawing.Point(230, 60);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Lime;
            this.btnEditar.Location = new System.Drawing.Point(132, 60);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.Location = new System.Drawing.Point(328, 60);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Lime;
            this.btnBorrar.Location = new System.Drawing.Point(430, 60);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(30, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lineaTransportesDataSet
            // 
            this.lineaTransportesDataSet.DataSetName = "LineaTransportesDataSet";
            this.lineaTransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autobusBindingSource
            // 
            this.autobusBindingSource.DataMember = "Autobus";
            this.autobusBindingSource.DataSource = this.lineaTransportesDataSet;
            // 
            // autobusTableAdapter
            // 
            this.autobusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutobusTableAdapter = this.autobusTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoletoTableAdapter = null;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autobusDataGridView
            // 
            this.autobusDataGridView.AllowUserToAddRows = false;
            this.autobusDataGridView.AllowUserToDeleteRows = false;
            this.autobusDataGridView.AutoGenerateColumns = false;
            this.autobusDataGridView.BackgroundColor = System.Drawing.Color.Gold;
            this.autobusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autobusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.autobusDataGridView.DataSource = this.autobusBindingSource;
            this.autobusDataGridView.Location = new System.Drawing.Point(12, 103);
            this.autobusDataGridView.Name = "autobusDataGridView";
            this.autobusDataGridView.ReadOnly = true;
            this.autobusDataGridView.Size = new System.Drawing.Size(644, 198);
            this.autobusDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "N# Acientos";
            this.dataGridViewTextBoxColumn4.HeaderText = "N# Acientos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Año de Fabricación";
            this.dataGridViewTextBoxColumn5.HeaderText = "Año de Fabricación";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Km";
            this.dataGridViewTextBoxColumn6.HeaderText = "Km";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(codigoLabel);
            this.panel2.Controls.Add(this.codigoTextBox);
            this.panel2.Controls.Add(tipoLabel);
            this.panel2.Controls.Add(this.tipoTextBox);
            this.panel2.Controls.Add(marcaLabel);
            this.panel2.Controls.Add(this.marcaTextBox);
            this.panel2.Controls.Add(n__AcientosLabel);
            this.panel2.Controls.Add(this.n__AcientosTextBox);
            this.panel2.Controls.Add(año_de_FabricaciónLabel);
            this.panel2.Controls.Add(this.año_de_FabricaciónTextBox);
            this.panel2.Controls.Add(kmLabel);
            this.panel2.Controls.Add(this.kmTextBox);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(662, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 198);
            this.panel2.TabIndex = 32;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autobusBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(119, 18);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autobusBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(119, 44);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 3;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autobusBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(119, 70);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 5;
            // 
            // n__AcientosTextBox
            // 
            this.n__AcientosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autobusBindingSource, "N# Acientos", true));
            this.n__AcientosTextBox.Location = new System.Drawing.Point(119, 96);
            this.n__AcientosTextBox.Name = "n__AcientosTextBox";
            this.n__AcientosTextBox.Size = new System.Drawing.Size(100, 20);
            this.n__AcientosTextBox.TabIndex = 7;
            // 
            // año_de_FabricaciónTextBox
            // 
            this.año_de_FabricaciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autobusBindingSource, "Año de Fabricación", true));
            this.año_de_FabricaciónTextBox.Location = new System.Drawing.Point(119, 122);
            this.año_de_FabricaciónTextBox.Name = "año_de_FabricaciónTextBox";
            this.año_de_FabricaciónTextBox.Size = new System.Drawing.Size(100, 20);
            this.año_de_FabricaciónTextBox.TabIndex = 9;
            // 
            // kmTextBox
            // 
            this.kmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autobusBindingSource, "Km", true));
            this.kmTextBox.Location = new System.Drawing.Point(119, 148);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmTextBox.TabIndex = 11;
            // 
            // frmAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(948, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.autobusDataGridView);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutobus";
            this.Text = "frmAutobus";
            this.Load += new System.EventHandler(this.frmAutobus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private LineaTransportesDataSet lineaTransportesDataSet;
        private System.Windows.Forms.BindingSource autobusBindingSource;
        private LineaTransportesDataSetTableAdapters.AutobusTableAdapter autobusTableAdapter;
        private LineaTransportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView autobusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox n__AcientosTextBox;
        private System.Windows.Forms.TextBox año_de_FabricaciónTextBox;
        private System.Windows.Forms.TextBox kmTextBox;
    }
}