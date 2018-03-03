using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Classes;

namespace Calculadora.Classes
{
    public class Controle
    {
        public String Converte(String Valor1, String Valor2, Double TipoDeCalculo) //metodo converte da classe controle
        {
            Operacoes Op = new Operacoes();
            String ResultadoCalculo = "";
            try
            {
                Op.Valor1 = Convert.ToDouble(Valor1);
                Op.Valor2 = Convert.ToDouble(Valor2);
                switch(TipoDeCalculo)
                {
                    case 1:
                        ResultadoCalculo = Op.Somar();
                        break;
                    case 2:
                        ResultadoCalculo = Op.Subtrair();
                        break;
                    case 3:
                        ResultadoCalculo = Op.Dividir();
                        break;
                    case 4:
                        ResultadoCalculo = Op.Multiplicar();
                        break;
                }
            }
            catch (Exception)
            {
                ResultadoCalculo = ("Caracter inválido!");
                return ResultadoCalculo;
            }
            return ResultadoCalculo;
        } //fim metodo converte
    }
}