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
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text.Trim() == "")
            {
                MessageBox.Show("Digite o salario");
            }
            else
            {
                double salario, aum_15, aum_18, total;
                salario = Convert.ToDouble(txtSalario.Text);
                aum_15 = salario * 0.15;
                aum_18 = salario * 0.18;
                total = salario + aum_15 + aum_18;
                txtAum_15.Text = Convert.ToString(string.Format("R$" + aum_15));
                txtAum_18.Text = Convert.ToString(string.Format("R$" + aum_18));
                txtTotal.Text = Convert.ToString(string.Format("R$" + total));
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
