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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTemp.Text.Trim() == "")
            {
                MessageBox.Show("Digite a temperatura");
            }
            else
            {
                double temp, farh;
                temp = Convert.ToDouble(txtTemp.Text);
                farh = (9 * temp + 160) / 5.0;
                lblValor.Text = Convert.ToString(farh + " F");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTemp.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
