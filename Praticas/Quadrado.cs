using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praticas
{
    public partial class Quadrado : Form
    {
        public Quadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLado1.Text.Trim() == "")
            {
                MessageBox.Show("Digite o lado 1 do quadrado");
            }
            else if (txtLado2.Text.Trim() == "")
            {
                MessageBox.Show("Digite o lado 2 do quadrado");
            } else
            {
                double lado1, lado2, area, dobroArea;
                lado1 = Convert.ToDouble(txtLado1.Text);
                lado2 = Convert.ToDouble(txtLado2.Text);
                area = lado1 * lado2;
                dobroArea = area * 2;
                txtArea.Text = Convert.ToString(area);
                txtDobro.Text = Convert.ToString(dobroArea);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quadrado_Load(object sender, EventArgs e)
        {
            txtArea.BackColor = Color.White;
            txtDobro.BackColor = Color.White;
        }

        private void txtLado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
