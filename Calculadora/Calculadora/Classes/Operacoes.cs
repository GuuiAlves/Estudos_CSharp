using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class Operacoes
    {
        public Double Valor1;
        public Double Valor2;
        public Double resposta;
        public String resultado;

        public String Somar()
        {
            resposta = Valor1 + Valor2;
            resultado = resposta.ToString();
            return resultado;
        }
        public String Subtrair()
        {
            resposta = Valor1 - Valor2;
            resultado = resposta.ToString();
            return resultado;
        }
        public String Dividir()
        {
            if(this.Valor1 == 0)
            {
                return resultado = "Erro, divisão por zero!";
            }
            resposta = Valor1 / Valor2;
            resultado = resposta.ToString();
            return resultado;
        }
        public String Multiplicar()
        {
            resposta = Valor1 * Valor2;
            resultado = resposta.ToString();
            return resultado;
        }
    }
}