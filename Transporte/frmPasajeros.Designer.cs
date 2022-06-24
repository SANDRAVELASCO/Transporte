namespace Transporte
{
    partial class frmPasajeros
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label n__de_cedulaLabel;
            System.Windows.Forms.Label fecha_de_NacimientoLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direcciónLabel;
            this.pasajerosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaTransportesDataSet = new Transporte.LineaTransportesDataSet();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.n__de_cedulaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pasajerosTableAdapter = new Transporte.LineaTransportesDataSetTableAdapters.PasajerosTableAdapter();
            this.tableAdapterManager = new Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            n__de_cedulaLabel = new System.Windows.Forms.Label();
            fecha_de_NacimientoLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.ForeColor = System.Drawing.Color.Black;
            codigoLabel.Location = new System.Drawing.Point(27, 15);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(27, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.ForeColor = System.Drawing.Color.Black;
            apellidosLabel.Location = new System.Drawing.Point(27, 67);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "Apellidos:";
            // 
            // n__de_cedulaLabel
            // 
            n__de_cedulaLabel.AutoSize = true;
            n__de_cedulaLabel.ForeColor = System.Drawing.Color.Black;
            n__de_cedulaLabel.Location = new System.Drawing.Point(27, 93);
            n__de_cedulaLabel.Name = "n__de_cedulaLabel";
            n__de_cedulaLabel.Size = new System.Drawing.Size(72, 13);
            n__de_cedulaLabel.TabIndex = 8;
            n__de_cedulaLabel.Text = "N° de cedula:";
            // 
            // fecha_de_NacimientoLabel
            // 
            fecha_de_NacimientoLabel.AutoSize = true;
            fecha_de_NacimientoLabel.ForeColor = System.Drawing.Color.Black;
            fecha_de_NacimientoLabel.Location = new System.Drawing.Point(27, 120);
            fecha_de_NacimientoLabel.Name = "fecha_de_NacimientoLabel";
            fecha_de_NacimientoLabel.Size = new System.Drawing.Size(111, 13);
            fecha_de_NacimientoLabel.TabIndex = 10;
            fecha_de_NacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.ForeColor = System.Drawing.Color.Black;
            generoLabel.Location = new System.Drawing.Point(27, 145);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 12;
            generoLabel.Text = "Genero:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.ForeColor = System.Drawing.Color.Black;
            telefonoLabel.Location = new System.Drawing.Point(27, 171);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.ForeColor = System.Drawing.Color.Black;
            direcciónLabel.Location = new System.Drawing.Point(27, 197);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 16;
            direcciónLabel.Text = "Dirección:";
            // 
            // pasajerosDataGridView
            // 
            this.pasajerosDataGridView.AllowUserToAddRows = false;
            this.pasajerosDataGridView.AllowUserToDeleteRows = false;
            this.pasajerosDataGridView.AutoGenerateColumns = false;
            this.pasajerosDataGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.pasajerosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajerosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pasajerosDataGridView.DataSource = this.pasajerosBindingSource;
            this.pasajerosDataGridView.Location = new System.Drawing.Point(42, 287);
            this.pasajerosDataGridView.Name = "pasajerosDataGridView";
            this.pasajerosDataGridView.ReadOnly = true;
            this.pasajerosDataGridView.Size = new System.Drawing.Size(845, 204);
            this.pasajerosDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "N° de cedula";
            this.dataGridViewTextBoxColumn4.HeaderText = "N° de cedula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha de Nacimiento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha de Nacimiento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn6.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Dirección";
            this.dataGridViewTextBoxColumn8.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // pasajerosBindingSource
            // 
            this.pasajerosBindingSource.DataMember = "Pasajeros";
            this.pasajerosBindingSource.DataSource = this.lineaTransportesDataSet;
            // 
            // lineaTransportesDataSet
            // 
            this.lineaTransportesDataSet.DataSetName = "LineaTransportesDataSet";
            this.lineaTransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(144, 12);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(144, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(144, 64);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 7;
            // 
            // n__de_cedulaTextBox
            // 
            this.n__de_cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "N° de cedula", true));
            this.n__de_cedulaTextBox.Location = new System.Drawing.Point(144, 90);
            this.n__de_cedulaTextBox.Name = "n__de_cedulaTextBox";
            this.n__de_cedulaTextBox.Size = new System.Drawing.Size(200, 20);
            this.n__de_cedulaTextBox.TabIndex = 9;
            // 
            // fecha_de_NacimientoDateTimePicker
            // 
            this.fecha_de_NacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pasajerosBindingSource, "Fecha de Nacimiento", true));
            this.fecha_de_NacimientoDateTimePicker.Location = new System.Drawing.Point(144, 116);
            this.fecha_de_NacimientoDateTimePicker.Name = "fecha_de_NacimientoDateTimePicker";
            this.fecha_de_NacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_NacimientoDateTimePicker.TabIndex = 11;
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(144, 142);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(200, 20);
            this.generoTextBox.TabIndex = 13;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(144, 168);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Dirección", true));
            this.direcciónTextBox.Location = new System.Drawing.Point(144, 194);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(200, 20);
            this.direcciónTextBox.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(codigoLabel);
            this.panel1.Controls.Add(this.direcciónTextBox);
            this.panel1.Controls.Add(this.codigoTextBox);
            this.panel1.Controls.Add(direcciónLabel);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(apellidosLabel);
            this.panel1.Controls.Add(this.generoTextBox);
            this.panel1.Controls.Add(this.apellidosTextBox);
            this.panel1.Controls.Add(generoLabel);
            this.panel1.Controls.Add(n__de_cedulaLabel);
            this.panel1.Controls.Add(this.fecha_de_NacimientoDateTimePicker);
            this.panel1.Controls.Add(this.n__de_cedulaTextBox);
            this.panel1.Controls.Add(fecha_de_NacimientoLabel);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(405, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 223);
            this.panel1.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(58, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBorrar.Location = new System.Drawing.Point(160, 122);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(58, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditar.Location = new System.Drawing.Point(160, 68);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(258, 68);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSalir.Location = new System.Drawing.Point(258, 122);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 40);
            this.panel2.TabIndex = 25;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pasajerosTableAdapter
            // 
            this.pasajerosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutobusTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoletoTableAdapter = null;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = this.pasajerosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pasajerosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasajeros";
            this.Text = "frmPasajeros";
            this.Load += new System.EventHandler(this.frmPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LineaTransportesDataSet lineaTransportesDataSet;
        private System.Windows.Forms.BindingSource pasajerosBindingSource;
        private LineaTransportesDataSetTableAdapters.PasajerosTableAdapter pasajerosTableAdapter;
        private LineaTransportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pasajerosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox n__de_cedulaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_NacimientoDateTimePicker;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direcciónTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel2;
    }
}