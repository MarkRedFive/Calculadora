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
    public partial class calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public calculadora()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "9";
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            tbResultado.Text += ".";
        }
        private void btReturn_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            lbOperacao.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            tbResultado.Text = "";
            operacao = "SOMA";
            lbOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Você ainda não informou nenhum valor!");
            }
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                tbResultado.Text = Convert.ToString(valor1 + valor2);
            }
            if (operacao == "SUBTRACAO")
            {
                tbResultado.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "MULTIPLICACAO")
            {
                tbResultado.Text = Convert.ToString(valor1 * valor2);
            }
            if (operacao == "DIVISAO")
            {
                tbResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            tbResultado.Text = "";
            operacao = "SUBTRACAO";
            lbOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Você ainda não informou nenhum valor!");
            }
}

        private void btMulti_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            tbResultado.Text = "";
            operacao = "MULTIPLICACAO";
            lbOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Você ainda não informou nenhum valor!");
            }
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
            valor1 = decimal.Parse(tbResultado.Text, CultureInfo.InvariantCulture);
            tbResultado.Text = "";
            operacao = "DIVISAO";
            lbOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Você ainda não informou nenhum valor!");
            }
        }

        private void btReturn_Click_1(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbOperacao.Text = "";
        }
    }
}
