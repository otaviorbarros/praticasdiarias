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
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }
       
        List<double> lstMedia = new List<double>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, media;
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            n3 = Convert.ToDouble(txtN3.Text);
            n4 = Convert.ToDouble(txtN4.Text);
            media = calcularMedia(n1, n2, n3, n4);
            AddMedia(media);
            CarregarMedia();
        }
        private double calcularMedia(double n1, double n2, double n3, double n4)
        {
            return (n1 + n2 + n3 + n4) / 4;
        }
        private void AddMedia(double media)
        {
            lstMedia.Add(media);
        }
        private void CarregarMedia()
        {
            lBoxMedia.DataSource = null;
            lBoxMedia.DataSource = lstMedia;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int aprovado = 0, reprovado = 0, exame = 0;
            for (int i = 0; i < lstMedia.Count; i++)
            {
                if (lstMedia[i] < 40)
                {
                    reprovado++;
                    
                }else if (lstMedia[i] > 70)
                {
                    aprovado++;
                    
                } else
                {
                    exame++;
                    
                }

            }
            txtAprovados.Text = aprovado.ToString(txtAprovados.Text);
            txtExame.Text = exame.ToString(txtExame.Text);
            txtReprovados.Text = reprovado.ToString(txtReprovados.Text);
        }
    }
}
