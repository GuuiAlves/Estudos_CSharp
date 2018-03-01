using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Classes.Controle c = new Classes.Controle(); //declarado para todos botões

        private void btnSomar_Click(object sender, EventArgs e)
        {
            c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            c.Processamentos(1);
            lblResultado.Text = c.Resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            c.Processamentos(2);
            lblResultado.Text = c.Resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            c.Processamentos(3);
            lblResultado.Text = c.Resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text);
            c.Processamentos(4);
            lblResultado.Text = c.Resultado.ToString();
        }
    }
}