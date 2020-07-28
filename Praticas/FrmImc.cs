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
    public partial class FrmImc : Form
    {

        public FrmImc()
        {
            InitializeComponent();
        }
        List<string> nome = new List<string>();
        List<double> imc = new List<double>();
        List<string> classificar = new List<string>();
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome;
            double peso, altura, imc;
            nome = txtNome.Text;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = CalcularImc(peso, altura);
            AddNome(nome);
            AddImc(imc);
            CarregarNome();
            CarregarImc();
            CarregarClassificar();
            LimparCampo();
                

        }


        private void AddNome(string pessoa)
        {
            nome.Add(pessoa);
        }
        private void AddImc(double calculoImc)
        {
            if (calculoImc < 18)
            {
                classificar.Add("Peso baixo");
                imc.Add(calculoImc);
            }
            else if (calculoImc > 18 && calculoImc < 25)
            {
                classificar.Add("Normal");
                imc.Add(calculoImc);
            }
            else if (calculoImc >= 25 && calculoImc < 30)
            {
                classificar.Add("SobrePeso");
                imc.Add(calculoImc);
            }
            else if (calculoImc >= 30 && calculoImc < 40)
            {
                classificar.Add("Obesidade");
                imc.Add(calculoImc);
            }
            else
            {
                classificar.Add("Obesidade grave");
                imc.Add(calculoImc);
            }
        }




        private double CalcularImc(double peso, double altura)
        {
            return (peso / (altura * altura)) * 10000 ;
        }
        private void CarregarNome()
        {
            lboxNome.DataSource = null;
            lboxNome.DataSource = nome;
        }
        private void CarregarClassificar()
        {
            lBoxClass.DataSource = null;
            lBoxClass.DataSource = classificar;
        }
        private void CarregarImc()
        {
            lBoxImc.DataSource = null;
            lBoxImc.DataSource = imc;
        }
        private void LimparCampo()
        {
            txtAltura.Clear();
            txtNome.Clear();
            txtPeso.Clear();
        }
    }
}
