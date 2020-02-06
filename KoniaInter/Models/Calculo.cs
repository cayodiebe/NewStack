using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoniaInter.Models
{
    public class Calculo
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public string operacao { get; set; }

        public double CalculaValores(Calculo calculo)
        {
            double total = 0;
            if (calculo.operacao == "+")
                total = calculo.valor1 + calculo.valor2;

            else if (calculo.operacao == "-")
                total = calculo.valor1 - calculo.valor2;
            else if (calculo.operacao == "*")
                total = calculo.valor1 * calculo.valor2;
            else if (calculo.operacao == "/")
                total = calculo.valor1 / calculo.valor2;

            return total;
        }
    }
}
