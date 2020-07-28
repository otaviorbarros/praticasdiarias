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
    public partial class FrmLouco : Form
    {
        public FrmLouco()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text == "" ? 0 : Convert.ToDouble(txtN1.Text));
            
            if (n1 == 44332)
            {
                txtN2.Enabled = true;
                txtN3.Enabled = true;
                btnSomar.Enabled = true;
            }else
            {
                MessageBox.Show("Codigo incorreto!");
            }
        }
        private double Somar(double n2, Double n3)
        {
            return n2 + n3;
        }


        private double Media(double n1, double n2, double n3, double n4, double n5, double n6)
        {
            return (n1 + n2 + n3 + n4 + n5 + n6) / 6;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text == "" ? 0 : Convert.ToDouble(txtN1.Text));
            double n2 = Convert.ToDouble(txtN2.Text == "" ? 0 : Convert.ToDouble(txtN2.Text));
            double n3 = Convert.ToDouble(txtN3.Text == "" ? 0 : Convert.ToDouble(txtN3.Text));
            double n4 = Convert.ToDouble(txtN4.Text == "" ? 0 : Convert.ToDouble(txtN4.Text));
            double n5 = Convert.ToDouble(txtN5.Text == "" ? 0 : Convert.ToDouble(txtN5.Text));
            double n6 = Convert.ToDouble(txtN6.Text == "" ? 0 : Convert.ToDouble(txtN6.Text));

            double media = Media(n1, n2, n3, n4, n5, n6);
            lblResult.Text = media.ToString(string.Format("F2"));
        }
        
        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n2 = Convert.ToDouble(txtN2.Text == "" ? 0 : Convert.ToDouble(txtN2.Text));
            double n3 = Convert.ToDouble(txtN3.Text == "" ? 0 : Convert.ToDouble(txtN3.Text));
            double soma = Somar(n2, n3);
            if (soma == 5543)
            {
                txtN4.Enabled = true;
                txtN5.Enabled = true;
                txtN6.Enabled = true;
                btnMedia.Enabled = true;
                lblSoma.Text = soma.ToString();
            }else
            {
                MessageBox.Show("Codigo não confere");
            }
            
        }
    }
}
