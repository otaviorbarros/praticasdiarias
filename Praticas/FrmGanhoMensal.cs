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
    public partial class FrmGanhoMensal : Form
    {
        public FrmGanhoMensal()
        {
            InitializeComponent();
        }
        List<string> mes = new List<string>();
        List<double> entrada = new List<double>();
        List<double> saida = new List<double>();
        List<double> saldo = new List<double>();
        private void btnInserir_Click(object sender, EventArgs e)
        {
            string mes;
            double entrada, saida, calculo;
            mes = txtMes.Text;
            entrada = Convert.ToDouble(txtEntrada.Text);
            saida = Convert.ToDouble(txtSaida.Text);
            calculo = CalcularSaldo(entrada, saida);
            AddMes(mes);
            AddEntrada(entrada);
            AddSaida(saida);
            AddSaldo(calculo);
            CarregarMes();
            CarregarEntrada();
            CarregarSaida();
            CarregarSaldo();
            LimparCampo();

        }
        private double CalcularSaldo(double entrada, double saida)
        {
            return entrada - saida;
        }
     

        private void AddMes(string m)
        {
            mes.Add(m);
        }
        private void AddEntrada(double e)
        {
            entrada.Add(e);
        }
        private void AddSaida(double s)
        {
            saida.Add(s);
        }
        private void AddSaldo(double s)
        {
            saldo.Add(s);
        }
        private void CarregarMes()
        {
            lbxMes.DataSource = null;
            lbxMes.DataSource = mes;
        }
        private void CarregarEntrada()
        {
            lbxEntrada.DataSource = null;
            lbxEntrada.DataSource = entrada;
        }
        private void CarregarSaida()
        {
            lbxSaida.DataSource = null;
            lbxSaida.DataSource = saida;
        }
        private void CarregarSaldo()
        {
            lbxSaldo.DataSource = null;
            lbxSaldo.DataSource = saldo;
        }
             
             
        private void LimparCampo()
        {
            txtEntrada.Clear();
            txtMes.Clear();
            txtSaida.Clear();
        }
        private void SomarRenda(double valor)
        {
            valor = valor + 0;
        }

        private void btnCalcularAnual_Click(object sender, EventArgs e)
        {
        }
    }
}
