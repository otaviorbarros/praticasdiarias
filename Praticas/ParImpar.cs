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
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
        }

        private void ParImpar_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text.Trim() == "")
            {
                MessageBox.Show("Digite um número!");
             }
            else
            {
                double num;
                num = Convert.ToDouble(txtNumero.Text);
                if (num % 2 == 0)
                {
                    MessageBox.Show("É um número par!");
                }
                else
                {
                    MessageBox.Show("É um número impar!");
                }
            }
        }
    }
}
