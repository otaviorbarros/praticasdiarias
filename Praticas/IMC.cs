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
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }
        List<string> nome = new List<string>();
        List<double> imc = new List<double>();
        List<string> classe = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            string nome;
            nome = txtNome.Text;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = CalculoImc(peso, altura);
            
            AddNome(nome);
            AddImc(imc);

            CarregarNome();
            CarregarImc();
            CarregarClassificacao();
        }
        private double CalculoImc(double peso, double altura)
        {
            return peso / (altura * altura);
            if (peso < 18.4)
            {
                AddClassificacao("Abaixo do peso");
                lbxClass.Items.Add("eita");
            }
            else if (peso < 25)
            {
                AddClassificacao("Peso normal");
            }
            else if (peso < 30)
            {
                AddClassificacao("Sobrepeso");
            }
            else if (peso < 35)
            {
                AddClassificacao("Obesidade grau 1");
            }
            else if (peso < 40)
            {
                AddClassificacao("obesidade grau 2");
            }
            else if (peso > 40)
            {
                AddClassificacao("obesidade grau 3");
            }
        }
       
        private void AddNome(string n)
        {
            nome.Add(n);
        }
        private void AddImc(double n)
        {
            imc.Add(n);
        }
        private void AddClassificacao(string n)
        {
            classe.Add(n);
        }
        private void CarregarNome()
        {
            lbxNome.DataSource = null;
            lbxNome.DataSource = nome;
        }
        private void CarregarImc()
        {
            lbxImc.DataSource = null;
            lbxImc.DataSource = imc;
        }
        private void CarregarClassificacao()
        {
            lbxClass.DataSource = null;
            lbxClass.DataSource = classe;
        }
    }
}
