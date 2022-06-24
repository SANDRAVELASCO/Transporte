namespace Transporte
{
    partial class FrmMenu
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
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnAutobus = new System.Windows.Forms.Button();
            this.btnChofer = new System.Windows.Forms.Button();
            this.btnBoleto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.BackColor = System.Drawing.Color.Plum;
            this.btnPasajeros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasajeros.Location = new System.Drawing.Point(120, 100);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(284, 44);
            this.btnPasajeros.TabIndex = 0;
            this.btnPasajeros.Text = "Pasajeros";
            this.btnPasajeros.UseVisualStyleBackColor = false;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            this.btnPasajeros.MouseEnter += new System.EventHandler(this.btnPasajeros_MouseEnter);
            this.btnPasajeros.MouseLeave += new System.EventHandler(this.btnPasajeros_MouseLeave);
            // 
            // btnAutobus
            // 
            this.btnAutobus.BackColor = System.Drawing.Color.Violet;
            this.btnAutobus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobus.Location = new System.Drawing.Point(120, 150);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Size = new System.Drawing.Size(284, 44);
            this.btnAutobus.TabIndex = 1;
            this.btnAutobus.Text = "Autobus";
            this.btnAutobus.UseVisualStyleBackColor = false;
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            this.btnAutobus.MouseEnter += new System.EventHandler(this.btnAutobus_MouseEnter);
            this.btnAutobus.MouseLeave += new System.EventHandler(this.btnAutobus_MouseLeave);
            // 
            // btnChofer
            // 
            this.btnChofer.BackColor = System.Drawing.Color.Magenta;
            this.btnChofer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChofer.Location = new System.Drawing.Point(120, 200);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(284, 44);
            this.btnChofer.TabIndex = 2;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.UseVisualStyleBackColor = false;
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            this.btnChofer.MouseEnter += new System.EventHandler(this.btnChofer_MouseEnter);
            this.btnChofer.MouseLeave += new System.EventHandler(this.btnChofer_MouseLeave);
            // 
            // btnBoleto
            // 
            this.btnBoleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBoleto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleto.Location = new System.Drawing.Point(120, 249);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(284, 44);
            this.btnBoleto.TabIndex = 3;
            this.btnBoleto.Text = "Boleto";
            this.btnBoleto.UseVisualStyleBackColor = false;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            this.btnBoleto.MouseEnter += new System.EventHandler(this.btnBoleto_MouseEnter);
            this.btnBoleto.MouseLeave += new System.EventHandler(this.btnBoleto_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auto Transportes de Tlaxiaco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(471, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 40);
            this.panel1.TabIndex = 6;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(503, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoleto);
            this.Controls.Add(this.btnChofer);
            this.Controls.Add(this.btnAutobus);
            this.Controls.Add(this.btnPasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnAutobus;
        private System.Windows.Forms.Button btnChofer;
        private System.Windows.Forms.Button btnBoleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}