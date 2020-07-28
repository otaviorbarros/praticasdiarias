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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Digite uma senha");
            }
            else
            {
                int num;
                num = Convert.ToInt32(txtSenha.Text);
                if (num == 4433)
                {
                    MessageBox.Show("Senha correta");
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
