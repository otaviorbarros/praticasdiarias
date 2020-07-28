using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Praticas
{
    public partial class Desconto : Form
    {
        public Desconto()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim() == "")
            {
                MessageBox.Show("Digite um valor");
            } else {
                double valor, desconto, novoValor;

                valor = Convert.ToDouble(txtValor.Text);
                desconto = valor * 0.09;
                novoValor = valor - desconto;
                lblDesconto.BackColor = Color.Red;
                lblDesconto.Text = desconto.ToString(string.Format("C", "F2", desconto));
                lblSub.BackColor = Color.Gray;
                lblSub.Text = valor.ToString(string.Format("C", valor));
                lblTotal.BackColor = Color.Green;
                lblTotal.Text = novoValor.ToString(string.Format("C", novoValor));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = txtValor.Text.Contains(',');
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
