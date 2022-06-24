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
    public partial class frmPasajeros : Form
    {
        public frmPasajeros()
        {
            InitializeComponent();
        }

        private void pasajerosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pasajerosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lineaTransportesDataSet);

        }

        private void frmPasajeros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lineaTransportesDataSet.Pasajeros' Puede moverla o quitarla según sea necesario.
            this.pasajerosTableAdapter.Fill(this.lineaTransportesDataSet.Pasajeros);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pasajerosBindingSource.AddNew();           
            panel1.Enabled = true;           
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
            codigoTextBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            codigoTextBox.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pasajerosBindingSource.EndEdit();//el campo se actualiza o se modifica
            this.pasajerosTableAdapter.Update(lineaTransportesDataSet.Pasajeros);
            this.pasajerosDataGridView.Refresh();

            panel1.Enabled = false;          
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desa borrar", "Borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.pasajerosTableAdapter.Delete(Convert.ToInt32(codigoTextBox.Text));
                this.lineaTransportesDataSet.Pasajeros.Rows.RemoveAt(this.pasajerosDataGridView.CurrentCell.RowIndex);
                this.pasajerosTableAdapter.Update(lineaTransportesDataSet.Pasajeros);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnCancelar.Visible = false;
            btnGuardar.Enabled = false;
            pasajerosBindingSource.CancelEdit();
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
    }
}
