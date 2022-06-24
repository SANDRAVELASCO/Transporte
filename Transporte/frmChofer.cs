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
    public partial class frmChofer : Form
    {
        public frmChofer()
        {
            InitializeComponent();
        }

        private void choferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.choferBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lineaTransportesDataSet);

        }

        private void frmChofer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lineaTransportesDataSet.Chofer' Puede moverla o quitarla según sea necesario.
            this.choferTableAdapter.Fill(this.lineaTransportesDataSet.Chofer);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            choferBindingSource.AddNew();
            panel2.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            idTextBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            btnCancelar.Visible = true;
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            idTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            btnCancelar.Visible = false;
            btnGuardar.Enabled = false;
            choferBindingSource.CancelEdit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.choferBindingSource.EndEdit();//el campo se actualiza o se modifica
            this.choferTableAdapter.Update(lineaTransportesDataSet.Chofer);
            this.choferDataGridView.Refresh();

            panel2.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Visible = false;
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desa borrar", "Borrar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.choferTableAdapter.Delete(idTextBox.Text);
                this.lineaTransportesDataSet.Chofer.Rows.RemoveAt(this.choferDataGridView.CurrentCell.RowIndex);
                this.choferTableAdapter.Update(lineaTransportesDataSet.Chofer);
            }
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

