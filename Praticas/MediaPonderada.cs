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
    public partial class MediaPonderada : Form
    {
        public MediaPonderada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == "")
            {
                MessageBox.Show("Digite a nota 1");
            }
            else if (txtN2.Text.Trim() == "")
            {
                MessageBox.Show("Digite a nota 2");
            }
            else if (txtN3.Text.Trim() == "")
            {
                MessageBox.Show("Digite a nota 3");
            }
            else if (txtN4.Text.Trim() == "")
            {
                MessageBox.Show("Digite a nota 4");
            }
            else
            {
                double n1, n2, n3, n4, media;

                n1 = Convert.ToDouble(txtN1.Text);
                n2 = Convert.ToDouble(txtN2.Text);
                n3 = Convert.ToDouble(txtN3.Text);
                n4 = Convert.ToDouble(txtN4.Text);

                media = (n1 * 2.0 + n2 * 4.0 + n3 * 6.0 + n4 * 8.0) / 20.0;

                lblMedia.Text = Convert.ToString(media);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
