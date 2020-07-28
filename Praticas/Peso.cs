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
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text.Trim() == "")
            {
                MessageBox.Show("Digite o peso");
            }
            else
            {
                double peso, peso_15, peso_20;
                peso = Convert.ToDouble(txtPeso.Text);
                peso_15 = (peso * 0.15) + peso;
                peso_20 = peso - (peso * 0.20);

                lbl15.BackColor = Color.Green;
                lbl15.Text = Convert.ToString(peso_15);
                lbl20.BackColor = Color.Red;
                lbl20.Text = Convert.ToString(peso_20);
                lblPeso.Text = Convert.ToString(peso);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
