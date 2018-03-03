using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Classes;

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
            lblResultado.Text = c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text, 1); //somar é = identificador 1;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text, 2); //somar é = identificador 2;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text, 3); //somar é = identificador 3;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = c.Converte(txbPrimeiroNumero.Text, txbSegundoNumero.Text, 4); //somar é = identificador 4;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}