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


        //Pode ser que o método esteja quebrado!
        public double CalculaValores(Calculo calculo)
        {
            double total = 0;
            double totalSoma = 0;
            double totalSubtracao = 0;

            if (calculo.operacao == "+")
                total = calculo.valor1 + calculo.valor1;
            if (calculo.operacao == "-")
                total = calculo.valor1 - calculo.valor1;
            if (calculo.operacao == "*")
                totalSubtracao = calculo.valor1 * calculo.valor1;
            if (calculo.operacao == "/")
                total = calculo.valor1 + calculo.valor1;

            return total;
        }
    }
}
