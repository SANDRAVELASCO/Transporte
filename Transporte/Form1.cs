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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Sandra")
            {
                if (textBox2.Text == "velguzzz")
                {
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Username incorrecto");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        int posY = 0;
        int posX = 0;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
