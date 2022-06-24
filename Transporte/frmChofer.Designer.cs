namespace Transporte
{
    partial class frmChofer
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label fecha_de_NacimientoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label generoLabel;
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineaTransportesDataSet = new Transporte.LineaTransportesDataSet();
            this.choferTableAdapter = new Transporte.LineaTransportesDataSetTableAdapters.ChoferTableAdapter();
            this.choferDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableAdapterManager = new Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            fecha_de_NacimientoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            idLabel.ForeColor = System.Drawing.Color.Black;
            idLabel.Location = new System.Drawing.Point(8, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 32;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(8, 42);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 34;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            apellidosLabel.ForeColor = System.Drawing.Color.Black;
            apellidosLabel.Location = new System.Drawing.Point(8, 68);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 36;
            apellidosLabel.Text = "Apellidos:";
            // 
            // fecha_de_NacimientoLabel
            // 
            fecha_de_NacimientoLabel.AutoSize = true;
            fecha_de_NacimientoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            fecha_de_NacimientoLabel.ForeColor = System.Drawing.Color.Black;
            fecha_de_NacimientoLabel.Location = new System.Drawing.Point(8, 95);
            fecha_de_NacimientoLabel.Name = "fecha_de_NacimientoLabel";
            fecha_de_NacimientoLabel.Size = new System.Drawing.Size(111, 13);
            fecha_de_NacimientoLabel.TabIndex = 38;
            fecha_de_NacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            telefonoLabel.ForeColor = System.Drawing.Color.Black;
            telefonoLabel.Location = new System.Drawing.Point(8, 120);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 40;
            telefonoLabel.Text = "Telefono:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            generoLabel.ForeColor = System.Drawing.Color.Black;
            generoLabel.Location = new System.Drawing.Point(8, 146);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 42;
            generoLabel.Text = "Genero:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Location = new System.Drawing.Point(507, 58);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 30;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Location = new System.Drawing.Point(211, 58);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Magenta;
            this.btnEditar.Location = new System.Drawing.Point(113, 58);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Location = new System.Drawing.Point(307, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Location = new System.Drawing.Point(409, 58);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Location = new System.Drawing.Point(11, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 40);
            this.panel1.TabIndex = 31;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lineaTransportesDataSet
            // 
            this.lineaTransportesDataSet.DataSetName = "LineaTransportesDataSet";
            this.lineaTransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choferTableAdapter
            // 
            this.choferTableAdapter.ClearBeforeFill = true;
            // 
            // choferDataGridView
            // 
            this.choferDataGridView.AllowUserToAddRows = false;
            this.choferDataGridView.AllowUserToDeleteRows = false;
            this.choferDataGridView.AutoGenerateColumns = false;
            this.choferDataGridView.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.choferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.choferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.choferDataGridView.DataSource = this.choferBindingSource;
            this.choferDataGridView.Location = new System.Drawing.Point(12, 106);
            this.choferDataGridView.Name = "choferDataGridView";
            this.choferDataGridView.ReadOnly = true;
            this.choferDataGridView.Size = new System.Drawing.Size(641, 220);
            this.choferDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha de Nacimiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de Nacimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
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
            // choferBindingSource
            // 
            this.choferBindingSource.DataMember = "Chofer";
            this.choferBindingSource.DataSource = this.lineaTransportesDataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(125, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 33;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(125, 39);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 35;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(125, 65);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 37;
            // 
            // fecha_de_NacimientoDateTimePicker
            // 
            this.fecha_de_NacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.choferBindingSource, "Fecha de Nacimiento", true));
            this.fecha_de_NacimientoDateTimePicker.Location = new System.Drawing.Point(125, 91);
            this.fecha_de_NacimientoDateTimePicker.Name = "fecha_de_NacimientoDateTimePicker";
            this.fecha_de_NacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_NacimientoDateTimePicker.TabIndex = 39;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(125, 117);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 41;
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(125, 143);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(200, 20);
            this.generoTextBox.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(idLabel);
            this.panel2.Controls.Add(this.generoTextBox);
            this.panel2.Controls.Add(generoLabel);
            this.panel2.Controls.Add(nombreLabel);
            this.panel2.Controls.Add(this.telefonoTextBox);
            this.panel2.Controls.Add(this.nombreTextBox);
            this.panel2.Controls.Add(telefonoLabel);
            this.panel2.Controls.Add(apellidosLabel);
            this.panel2.Controls.Add(this.fecha_de_NacimientoDateTimePicker);
            this.panel2.Controls.Add(this.apellidosTextBox);
            this.panel2.Controls.Add(fecha_de_NacimientoLabel);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(659, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 200);
            this.panel2.TabIndex = 44;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutobusTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoletoTableAdapter = null;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1019, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.choferDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChofer";
            this.Text = "frmChofer";
            this.Load += new System.EventHandler(this.frmChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private LineaTransportesDataSet lineaTransportesDataSet;
        private System.Windows.Forms.BindingSource choferBindingSource;
        private LineaTransportesDataSetTableAdapters.ChoferTableAdapter choferTableAdapter;
        private LineaTransportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView choferDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_NacimientoDateTimePicker;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}