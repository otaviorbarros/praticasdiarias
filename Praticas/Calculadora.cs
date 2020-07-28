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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNum1_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim() == "")
            {
                MessageBox.Show("digite o primeiro numero");
            }else if (txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("digite o segundo numero");
            }
            else
            {
                double num1, num2, soma;
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);
                soma = num1 + num2;
                lblResultado.Text = Convert.ToString(soma);
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim() == "")
            {
                MessageBox.Show("digite o primeiro numero");
            }
            else if (txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("digite o segundo numero");
            }else
            {
                double num1, num2, subtrair;
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum1.Text);
                subtrair = num1 - num2;
                lblResultado.Text = Convert.ToString(subtrair);
            }
        }
    }
}
