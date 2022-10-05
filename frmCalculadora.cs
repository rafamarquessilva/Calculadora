using Calculadora.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        ETipoOperacao operacao;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case ETipoOperacao.Soma: txtResultado.Text = Convert.ToString(valor1 + valor2);
                    break;
                case ETipoOperacao.Subtracao: txtResultado.Text = Convert.ToString(valor1 - valor2);
                    break;
                case ETipoOperacao.Multiplicacao: txtResultado.Text = Convert.ToString(valor1 * valor2);
                    break;
                default: txtResultado.Text = Convert.ToString(valor1 / valor2);
                    break;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = ETipoOperacao.Soma;
            lblOperacao.Text = "+";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = ETipoOperacao.Subtracao;
            lblOperacao.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = ETipoOperacao.Multiplicacao;
            lblOperacao.Text = "x";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = ETipoOperacao.Divisao;
            lblOperacao.Text = "/";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}
