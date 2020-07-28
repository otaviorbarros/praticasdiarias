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
    public partial class Picole : Form
    {
        public Picole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void btnFinalizar_Click(object sender, EventArgs e)
        {
           
            double qtde, vtotal; 
            int tp1, tp2, tp3;
           
            
                qtde = Convert.ToDouble(txtQtde.Text);
                tp1 = Convert.ToInt32(lblTipo1.Text);
                tp2 = Convert.ToInt32(lblTipo2.Text);
                tp3 = Convert.ToInt32(lblTipo3.Text);
            
            vtotal = ((tp1 * 0.5) + (tp2 * 0.6) + (tp3 * 0.75)) * qtde;
            txtTotal.Text = vtotal.ToString(string.Format("C", vtotal));
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int lb1, lb2, lb3, qt, tipo;
            lb1 = 0;
            lb2 = 0;
            lb3 = 0;
            tipo = Convert.ToInt32(txtTipo.Text);
            qt = Convert.ToInt32(txtQtde.Text);
            switch (tipo)
            {
                case 1:
                    lb1 += qt;
                    lblTipo1.Text = Convert.ToString(lb1);
                    break;
                case 2:
                    lb2 += qt;
                    lblTipo2.Text = Convert.ToString(lb2);
                    break;
                case 3:
                    lb3 += qt;
                    lblTipo3.Text = Convert.ToString(lb3);
                    break;
            }

        }
    }
}
