using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praticas
{
    public partial class LojaInfo : Form
    {
        public LojaInfo()
        {
            InitializeComponent();
        }
        double valorTotal;
        double valorMouse = 25;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            double prod1 = Convert.ToDouble(txtMouse.Text.Trim() == "" ? 0 : Convert.ToDouble(txtMouse.Text));
            double prod2 = Convert.ToDouble(txtTeclado.Text.Trim() == "" ? 0 : Convert.ToDouble(txtTeclado.Text));
            double prod3 = Convert.ToDouble(txtDell.Text.Trim() == "" ? 0 : Convert.ToDouble(txtDell.Text));
            double prod4 = Convert.ToDouble(txtAcer.Text.Trim() == "" ? 0 : Convert.ToDouble(txtAcer.Text));
            double prod5 = Convert.ToDouble(txtPcGamer.Text.Trim() == "" ? 0 : Convert.ToDouble(txtPcGamer.Text));

            double mouse;
          
            mouse = Venda(prod1, valorMouse);
            double teclado, valorTeclado ;
            valorTeclado = 12;
            teclado = Venda(prod2, valorTeclado);
            double noteDell, valorDell;
            valorDell = 2500;
            noteDell = Venda(prod3, valorDell);
            double noteAcer, valorAcer;
            valorAcer = 3200;
            noteAcer = Venda(prod4, valorAcer);
            double pcGamer, valorPc;
            valorPc = 5000;
            pcGamer = Venda(prod5, valorPc);
            valorTotal = ValorTotal(mouse, teclado, noteDell, noteAcer, pcGamer);
            lblMouse.Text = mouse.ToString(string.Format("C"));
            lblTeclado.Text = teclado.ToString(string.Format("C"));
            lblDell.Text = noteDell.ToString(string.Format("C"));
            lblAcer.Text = noteAcer.ToString(string.Format("C"));
            lblGamer.Text = pcGamer.ToString(string.Format("C"));

        }
        private double Venda(double qtd, double valor)
        {
            return valor * qtd;
        }
        private double ValorTotal(double p1, double p2, double p3, double p4, double p5)
        {
            return p1 + p2 + p3 + p4 + p5;
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            lblTotal.Text = valorTotal.ToString(string.Format("C"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAcer.Clear();
            txtDell.Clear();
            txtMouse.Clear();
            txtPcGamer.Clear();
            txtTeclado.Clear();
            lblAcer.Text = "";
            lblDell.Text = "";
            lblGamer.Text = "";
            lblTeclado.Text = "";
            lblMouse.Text = "";
            lblTotal.Text = "";
        }
    }
}
