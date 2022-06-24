namespace Transporte
{
    partial class frmBoleto
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
            System.Windows.Forms.Label n__de_BoletoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label destinoLabel;
            System.Windows.Forms.Label hora_SalidaLabel;
            System.Windows.Forms.Label n__de_AcientoLabel;
            System.Windows.Forms.Label precioLabel;
            this.lineaTransportesDataSet = new Transporte.LineaTransportesDataSet();
            this.boletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boletoTableAdapter = new Transporte.LineaTransportesDataSetTableAdapters.BoletoTableAdapter();
            this.tableAdapterManager = new Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager();
            this.boletoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n__de_BoletoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.hora_SalidaTextBox = new System.Windows.Forms.TextBox();
            this.n__de_AcientoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            n__de_BoletoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            hora_SalidaLabel = new System.Windows.Forms.Label();
            n__de_AcientoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // n__de_BoletoLabel
            // 
            n__de_BoletoLabel.AutoSize = true;
            n__de_BoletoLabel.ForeColor = System.Drawing.Color.Black;
            n__de_BoletoLabel.Location = new System.Drawing.Point(15, 10);
            n__de_BoletoLabel.Name = "n__de_BoletoLabel";
            n__de_BoletoLabel.Size = new System.Drawing.Size(70, 13);
            n__de_BoletoLabel.TabIndex = 1;
            n__de_BoletoLabel.Text = "N° de Boleto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.Black;
            nombreLabel.Location = new System.Drawing.Point(15, 36);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.ForeColor = System.Drawing.Color.Black;
            apellidosLabel.Location = new System.Drawing.Point(15, 62);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.ForeColor = System.Drawing.Color.Black;
            destinoLabel.Location = new System.Drawing.Point(15, 88);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(46, 13);
            destinoLabel.TabIndex = 7;
            destinoLabel.Text = "Destino:";
            // 
            // hora_SalidaLabel
            // 
            hora_SalidaLabel.AutoSize = true;
            hora_SalidaLabel.ForeColor = System.Drawing.Color.Black;
            hora_SalidaLabel.Location = new System.Drawing.Point(15, 114);
            hora_SalidaLabel.Name = "hora_SalidaLabel";
            hora_SalidaLabel.Size = new System.Drawing.Size(65, 13);
            hora_SalidaLabel.TabIndex = 9;
            hora_SalidaLabel.Text = "Hora Salida:";
            // 
            // n__de_AcientoLabel
            // 
            n__de_AcientoLabel.AutoSize = true;
            n__de_AcientoLabel.ForeColor = System.Drawing.Color.Black;
            n__de_AcientoLabel.Location = new System.Drawing.Point(15, 140);
            n__de_AcientoLabel.Name = "n__de_AcientoLabel";
            n__de_AcientoLabel.Size = new System.Drawing.Size(76, 13);
            n__de_AcientoLabel.TabIndex = 11;
            n__de_AcientoLabel.Text = "N° de Aciento:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.ForeColor = System.Drawing.Color.Black;
            precioLabel.Location = new System.Drawing.Point(15, 166);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 13;
            precioLabel.Text = "Precio:";
            // 
            // lineaTransportesDataSet
            // 
            this.lineaTransportesDataSet.DataSetName = "LineaTransportesDataSet";
            this.lineaTransportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boletoBindingSource
            // 
            this.boletoBindingSource.DataMember = "Boleto";
            this.boletoBindingSource.DataSource = this.lineaTransportesDataSet;
            // 
            // boletoTableAdapter
            // 
            this.boletoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutobusTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoletoTableAdapter = this.boletoTableAdapter;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transporte.LineaTransportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // boletoDataGridView
            // 
            this.boletoDataGridView.AllowUserToAddRows = false;
            this.boletoDataGridView.AllowUserToDeleteRows = false;
            this.boletoDataGridView.AutoGenerateColumns = false;
            this.boletoDataGridView.BackgroundColor = System.Drawing.Color.Magenta;
            this.boletoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boletoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.boletoDataGridView.DataSource = this.boletoBindingSource;
            this.boletoDataGridView.Location = new System.Drawing.Point(12, 93);
            this.boletoDataGridView.Name = "boletoDataGridView";
            this.boletoDataGridView.ReadOnly = true;
            this.boletoDataGridView.Size = new System.Drawing.Size(737, 263);
            this.boletoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "N° de Boleto";
            this.dataGridViewTextBoxColumn1.HeaderText = "N° de Boleto";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Destino";
            this.dataGridViewTextBoxColumn4.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hora Salida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora Salida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "N° de Aciento";
            this.dataGridViewTextBoxColumn6.HeaderText = "N° de Aciento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // n__de_BoletoTextBox
            // 
            this.n__de_BoletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "N° de Boleto", true));
            this.n__de_BoletoTextBox.Location = new System.Drawing.Point(97, 7);
            this.n__de_BoletoTextBox.Name = "n__de_BoletoTextBox";
            this.n__de_BoletoTextBox.Size = new System.Drawing.Size(124, 20);
            this.n__de_BoletoTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(97, 33);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(124, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(97, 59);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(124, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "Destino", true));
            this.destinoTextBox.Location = new System.Drawing.Point(97, 85);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.Size = new System.Drawing.Size(124, 20);
            this.destinoTextBox.TabIndex = 8;
            // 
            // hora_SalidaTextBox
            // 
            this.hora_SalidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "Hora Salida", true));
            this.hora_SalidaTextBox.Location = new System.Drawing.Point(97, 111);
            this.hora_SalidaTextBox.Name = "hora_SalidaTextBox";
            this.hora_SalidaTextBox.Size = new System.Drawing.Size(124, 20);
            this.hora_SalidaTextBox.TabIndex = 10;
            // 
            // n__de_AcientoTextBox
            // 
            this.n__de_AcientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "N° de Aciento", true));
            this.n__de_AcientoTextBox.Location = new System.Drawing.Point(97, 137);
            this.n__de_AcientoTextBox.Name = "n__de_AcientoTextBox";
            this.n__de_AcientoTextBox.Size = new System.Drawing.Size(124, 20);
            this.n__de_AcientoTextBox.TabIndex = 12;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boletoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(97, 163);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(124, 20);
            this.precioTextBox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.apellidosTextBox);
            this.panel1.Controls.Add(n__de_BoletoLabel);
            this.panel1.Controls.Add(this.precioTextBox);
            this.panel1.Controls.Add(this.n__de_BoletoTextBox);
            this.panel1.Controls.Add(precioLabel);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.n__de_AcientoTextBox);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(n__de_AcientoLabel);
            this.panel1.Controls.Add(apellidosLabel);
            this.panel1.Controls.Add(this.hora_SalidaTextBox);
            this.panel1.Controls.Add(hora_SalidaLabel);
            this.panel1.Controls.Add(destinoLabel);
            this.panel1.Controls.Add(this.destinoTextBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(755, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 204);
            this.panel1.TabIndex = 15;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Lime;
            this.BtnSalir.Location = new System.Drawing.Point(555, 53);
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
            this.btnCancelar.Location = new System.Drawing.Point(250, 53);
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
            this.btnEditar.Location = new System.Drawing.Point(152, 53);
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
            this.btnGuardar.Location = new System.Drawing.Point(355, 53);
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
            this.btnBorrar.Location = new System.Drawing.Point(457, 53);
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
            this.btnAgregar.Location = new System.Drawing.Point(50, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 40);
            this.panel2.TabIndex = 31;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // frmBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1005, 368);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boletoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoleto";
            this.Text = "frmBoleto";
            this.Load += new System.EventHandler(this.frmBoleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineaTransportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LineaTransportesDataSet lineaTransportesDataSet;
        private System.Windows.Forms.BindingSource boletoBindingSource;
        private LineaTransportesDataSetTableAdapters.BoletoTableAdapter boletoTableAdapter;
        private LineaTransportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView boletoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox n__de_BoletoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.TextBox hora_SalidaTextBox;
        private System.Windows.Forms.TextBox n__de_AcientoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
    }
}