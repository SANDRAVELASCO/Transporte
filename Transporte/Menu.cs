using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPasajeros_MouseEnter(object sender, EventArgs e)
        {
            this.btnPasajeros.BackColor = Color.LightBlue;
        }

        private void btnPasajeros_MouseLeave(object sender, EventArgs e)
        {
            this.btnPasajeros.BackColor = SystemColors.Control;
        }

        private void btnAutobus_MouseEnter(object sender, EventArgs e)
        {
            this.btnAutobus.BackColor = Color.LightBlue;
        }

        private void btnAutobus_MouseLeave(object sender, EventArgs e)
        {
            this.btnAutobus.BackColor = SystemColors.Control;
        }

        private void btnChofer_MouseEnter(object sender, EventArgs e)
        {
            this.btnChofer.BackColor = Color.LightBlue;
        }

        private void btnChofer_MouseLeave(object sender, EventArgs e)
        {
            this.btnChofer.BackColor = SystemColors.Control;
        }

        private void btnBoleto_MouseEnter(object sender, EventArgs e)
        {
            this.btnBoleto.BackColor = Color.LightBlue;
        }

        private void btnBoleto_MouseLeave(object sender, EventArgs e)
        {
            this.btnBoleto.BackColor = SystemColors.Control;
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            frmPasajeros frmPasajeros1 = new frmPasajeros();
            frmPasajeros1.Show();
            
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            frmAutobus frmAutobus1 = new frmAutobus();
            frmAutobus1.Show();
            
        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            frmChofer frmChofer1 = new frmChofer();
            frmChofer1.Show();
            
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            frmBoleto frmBoleto1 = new frmBoleto();
            frmBoleto1.Show();

        }

        int posY = 0;
        int posX = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
