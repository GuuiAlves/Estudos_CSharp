using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class Controle
    {
        public Double Valor1;
        public Double Valor2;
        public Double Resultado;

        public void Converte(String PrimeiroNumero, String SegundoNumero) //converte os numeros de entrada pelo usuario
        {
            this.Valor1 = Convert.ToDouble(PrimeiroNumero);
            this.Valor2 = Convert.ToDouble(SegundoNumero);
        }

        public void Processamentos(int Identificador) //identifica qual operacao o usuario clicou
        {
            switch(Identificador)
            {
                case 1:
                    Somar();
                    break;

                case 2:
                    Subtrair();
                    break;
                case 3:
                    Dividir();
                    break;
                case 4:
                    Multiplicar();
                    break;
            }
           
        }

        public void Somar()
        {
            this.Resultado = this.Valor1 + this.Valor2;
        }
        public void Subtrair()
        {
            this.Resultado = this.Valor1 - this.Valor2;
        }
        public void Dividir()
        {
            this.Resultado = this.Valor1 / this.Valor2;
        }
        public void Multiplicar()
        {
            this.Resultado = this.Valor1 * this.Valor2;
        }
    }
}