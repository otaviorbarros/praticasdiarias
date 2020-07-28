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
    public partial class FrmPerguntas : Form
    {
        public FrmPerguntas()
        {
            InitializeComponent();
        }



        private void btnAcancar2_Click(object sender, EventArgs e)
        {
            string resposta2 = txtResposta2.Text;
            if (SegundaEtapa(resposta2))
            {
                txtResposta3.Enabled = true;
                btnAcancar2.Enabled = true;
                btnFinalizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Resposta incorreta!");
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            char resposta3 = Convert.ToChar(txtResposta3.Text);
            if (TerceiraEtapa(resposta3))
            {
                MessageBox.Show("parabens"); 
                
            }else
            {
                MessageBox.Show("Resposta incorreta!");
            }
        }

        private void btnAvancar1_Click(object sender, EventArgs e)
        {
            int resposta = Convert.ToInt32(txtPrimeiro.Text.Trim() == "" ? 0 : Convert.ToInt32(txtPrimeiro.Text));
            if (PrimeiraEtapa(resposta))
            {
               btnAcancar2.Enabled = true;
                txtResposta2.Enabled = true;
            }else
            {
                btnAcancar2.Enabled = false;
                MessageBox.Show("Resposta incorreta!");
            }

        }
        private bool PrimeiraEtapa(int resposta)
        {
            if (resposta == 49)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool SegundaEtapa(string resposta)
        {
            if (resposta == "variavel")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool TerceiraEtapa(char resposta)
        {
            if (resposta == 's' || resposta == 'S')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
