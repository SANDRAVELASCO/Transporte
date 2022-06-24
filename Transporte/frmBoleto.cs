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
    public partial class frmBoleto : Form
    {
        public frmBoleto()
        {
            InitializeComponent();
        }

        private void boletoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.boletoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lineaTransportesDataSet);

        }

        private void frmBoleto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lineaTransportesDataSet.Boleto' Puede moverla o quitarla según sea necesario.
            this.boletoTableAdapter.Fill(this.lineaTransportesDataSet.Boleto);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            boletoBindingSource.AddNew();
            panel1.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
            n__de_BoletoTextBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            n__de_BoletoTextBox.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desa borrar", "Borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.boletoTableAdapter.Delete(Convert.ToInt32(n__de_BoletoTextBox.Text));
                this.lineaTransportesDataSet.Boleto.Rows.RemoveAt(this.boletoDataGridView.CurrentCell.RowIndex);
                this.boletoTableAdapter.Update(lineaTransportesDataSet.Boleto);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnCancelar.Visible = false;
            btnGuardar.Enabled = false;
            btnBorrar.Enabled = true;
            boletoBindingSource.CancelEdit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.boletoBindingSource.EndEdit();//el campo se actualiza o se modifica
            this.boletoTableAdapter.Update(lineaTransportesDataSet.Boleto);
            this.boletoDataGridView.Refresh();

            panel1.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;
            btnBorrar.Enabled = true;
        }

        int posY = 0;
        int posX = 0;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
