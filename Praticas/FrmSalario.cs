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
    public partial class FrmSalario : Form
    {
        public FrmSalario()
        {
            InitializeComponent();
        }
        List<double> lstSalario = new List<double>();
        List<double> lstFiltrar = new List<double>();
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private double CalcularAumento(double valor, double porcentagem)
        {
            return valor += valor * (porcentagem / 100);
        }
        private void CarregarListaSalario()
        {
            lboxSalFinal.DataSource = true;
            lboxSalFinal.DataSource = lstSalario;
        }
        private void CarregarListaFiltro()
        {
            lboxFiltro.DataSource = true;
            lboxFiltro.DataSource = lstFiltrar;
        }
        private void AddSalario(double n)
        {
            lstSalario.Add(n);
        }
        private void AddFiltro(double n)
        {
            lstFiltrar.Add(n);
        }
    }
}
