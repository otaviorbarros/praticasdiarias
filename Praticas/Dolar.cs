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
    public partial class Dolar : Form
    {
        public Dolar()
        {
            InitializeComponent();
        }
       

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim() == "")
            {
                MessageBox.Show("Digite um valor em dólar");
            }
  
            else if (txtCotacao.Text.Trim() == "")
            {
                MessageBox.Show("Digite a cotação do dólar");
            }
            else
            {
                double valorDolar, cotacao, valorReal;
                valorDolar = Convert.ToDouble(txtValor.Text);
                cotacao = Convert.ToDouble(txtCotacao.Text);
                valorReal = valorDolar * cotacao;
                MessageBox.Show(valorReal.ToString(string.Format("C")));

            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && e.KeyChar != (char)8)
            {
               
                e.Handled = true;
                MessageBox.Show("Este campo só permite números e virgula");
            }
        }

        private void txtCotacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Este campo só permite números e virgula");
            }
        }
    }
}
