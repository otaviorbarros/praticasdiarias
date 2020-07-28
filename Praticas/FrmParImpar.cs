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
    public partial class FrmParImpar : Form
    {
        public FrmParImpar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        List<int> listaPar = new List<int>();
        List<int> listaImpar = new List<int>();
        private void FrmParImpar_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtEntrada.Text);
            AddList(num);

        }
        private void AddList(int num)
        {
            if (num % 2 == 0)
            {
                listaPar.Add(num);
                CarregarListaPar();
                Limpar();
            }else
            {
                listaImpar.Add(num);
                CarregarListaImpar();
                Limpar();
            }
        }
        private void CarregarListaPar()
        {
            lbPar.DataSource = null;
            lbPar.DataSource = listaPar;
        }
        private void CarregarListaImpar()
        {
            lbImpar.DataSource = null;
            lbImpar.DataSource = listaImpar;
        }
        private void Limpar()
        {
            txtEntrada.Clear();

        }
       
    }
}
