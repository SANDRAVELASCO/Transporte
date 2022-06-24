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
    public partial class frmAutobus : Form
    {
        public frmAutobus()
        {
            InitializeComponent();
        }

        private void autobusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autobusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lineaTransportesDataSet);

        }

        private void frmAutobus_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lineaTransportesDataSet.Autobus' Puede moverla o quitarla según sea necesario.
            this.autobusTableAdapter.Fill(this.lineaTransportesDataSet.Autobus);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            autobusBindingSource.AddNew();
            panel2.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
            codigoTextBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            codigoTextBox.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.autobusBindingSource.EndEdit();//el campo se actualiza o se modifica
            this.autobusTableAdapter.Update(lineaTransportesDataSet.Autobus);
            this.autobusDataGridView.Refresh();

            panel2.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desa borrar", "Borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.autobusTableAdapter.Delete(Convert.ToInt32(codigoTextBox.Text));
                this.lineaTransportesDataSet.Autobus.Rows.RemoveAt(this.autobusDataGridView.CurrentCell.RowIndex);
                this.autobusTableAdapter.Update(lineaTransportesDataSet.Autobus);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            btnCancelar.Visible = false;
            btnGuardar.Enabled = false;
            autobusBindingSource.CancelEdit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

