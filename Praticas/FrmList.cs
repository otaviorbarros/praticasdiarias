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
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }
        List<double> salario = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double aumento = Convert.ToDouble(txtAumento.Text);
            double salFinal = AumentarSalario(salario, aumento);
            AddSalario(salFinal);
            CarregarLista();
            LimparCampos();
        }
        private double AumentarSalario(double salario, double porcentagem)
        {
            return salario += salario * porcentagem / 100.00;
        }
        private void CarregarLista()
        {
            lbSalarioCalculado.DataSource = null;
            lbSalarioCalculado.DataSource = salario;
        }
        private void AddSalario(double sal)
        {
            salario.Add(sal);
        }
        private void LimparCampos()
        {
            txtAumento.Clear();
            txtSalario.Clear();
        }
    }
}
