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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o campo nome");
                txtNome.Focus();
            }
            else if (txtSobrenome.Text.Trim() == "")
            {
                MessageBox.Show("preencha o sobrenome");
            }
            else
            {
                string nome, sobrenome, completo;
                nome = txtNome.Text.Trim();
                sobrenome = txtSobrenome.Text.Trim();

                completo = string.Concat(nome, " ", sobrenome);

                MessageBox.Show(string.Concat("nome completo: " + completo));
            }

        }
    }
}


