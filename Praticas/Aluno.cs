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
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {
            { 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text.Trim() == "")
            {
                MessageBox.Show("digite a nota primeiro bimestre");
            }
            else if (txtNota2.Text.Trim() == "")
            {
                MessageBox.Show("digite a nota do segundo bimestre");
            }
            else if (txtNota3.Text.Trim() == "")
            {
                MessageBox.Show("digite a nota do terceiro bim");
            }
            else if (txtNota4.Text.Trim() == "")
            {
                MessageBox.Show("digite a nota do quarto bim");
            }
            else
            {
                double nota1, nota2, nota3, nota4, media;
                nota1 = Convert.ToDouble(txtNota1.Text);
                nota2 = Convert.ToDouble(txtNota2.Text);
                nota3 = Convert.ToDouble(txtNota3.Text);
                nota4 = Convert.ToDouble(txtNota4.Text);
                media = (nota1 + nota2 + nota3 + nota4) / 4.0;
                txtMedia.Text = Convert.ToString(media);

                if (media < 30.0)
                {
                    lblSituacao.BackColor = Color.Red;
                    lblSituacao.ForeColor = Color.Black;
                    lblSituacao.Text = ("reprovado");
                }
                else if (media < 60)
                {
                    lblSituacao.BackColor = Color.Yellow;
                    lblSituacao.ForeColor = Color.Black;
                    lblSituacao.Text = ("exame");
                }
                else
                {
                    lblSituacao.BackColor = Color.Green;
                    lblSituacao.ForeColor = Color.Black;
                    lblSituacao.Text = ("aprovado");
                }
            }
        }

        private void Aluno_Load(object sender, EventArgs e)
        {

        }
    }
}
