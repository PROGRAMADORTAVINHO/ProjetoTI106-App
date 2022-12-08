using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraApp
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você clicou no botão calcular", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            /*double num1, num2, resp;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            resp = num1 + num2;

            lblSoma.Text = resp.ToString();
            */
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, soma = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            soma = num1 + num2;

            lblRespSoma.Text = soma.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double num1, num2, sub = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            sub = num1 - num2;

            lblRespSubtracao.Text = sub.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double num1, num2, mult = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            mult = num1 * num2;

            lblRespMultiplicacao.Text = mult.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double num1, num2, div = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            div = num1 / num2;

            lblRespDivisao.Text = div.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblRespSoma.Text = "";
            lblRespSubtracao.Text = "";
            lblRespMultiplicacao.Text = "";
            lblRespDivisao.Text = "";
        }
    }
}
