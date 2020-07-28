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
    public partial class FrmFuncao : Form
    {
        public FrmFuncao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble((txtNum_1.Text) == "" ? 0 : Convert.ToDouble(txtNum_1.Text));
            double num2 = Convert.ToDouble((txtNum_2.Text) == "" ? 0 : Convert.ToDouble(txtNum_2.Text));
            double num3 = Convert.ToDouble((txtNum_3.Text) == "" ? 0 : Convert.ToDouble(txtNum_3.Text));
            double num4 = Convert.ToDouble((txtNum_4.Text) == "" ? 0 : Convert.ToDouble(txtNum_4.Text));
            double num5 = Convert.ToDouble((txtNum_5.Text) == "" ? 0 : Convert.ToDouble(txtNum_5.Text));

            double calc1 = Calculo_1(num1, num2);
            double div = Dividir(calc1, num3);
            double quad = Quadrado(div, num4);
            double sub = Subtrair(quad, num5);
            lblResultado.Text = sub.ToString();
        }
        private double Calculo_1(double num1, double num2)
        {
            return num1 + num2;
        }
        private double Dividir(double result_cal1, double num3)
        {
            return result_cal1 / num3;
        }
        private double Quadrado(double result_div, double num4)
        {
            return result_div +(num4 * num4);
        } 
        private double Subtrair(double resultQuad, double num5)
        {
            return resultQuad - num5;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum_1.Clear();
            txtNum_2.Clear();
            txtNum_3.Clear();
            txtNum_4.Clear();
            txtNum_5.Clear();
            lblResultado.Text = "";
        }
    }
}
