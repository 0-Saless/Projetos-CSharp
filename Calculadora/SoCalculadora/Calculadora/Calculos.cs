using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Calcular
{
    public class Calculos
    {
        // Atributos e propriedades
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        // Construtores
        public Calculos()
        {
            Num1 = 0;
            Num2 = 0;
        }

        public Calculos(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        // Métodos de cálculo
        public string Somar()
        {
            return $"A soma de {Num1} e {Num2} é " + (Num1 + Num2) + "\n";
        }

        public string Subtrair()
        {
            return $"A subtração de {Num1} por {Num2} é " + (Num1 - Num2) + "\n";
        }
        public string Multiplicar()
        {
            return $"A multiplicação entre {Num1} e {Num2} é " + (Num1 * Num2) + "\n";
        }

        public string Dividir()
        {
            if (Num2 == 0)
                return "Erro: Divisão por zero!";
            return $"A divisão de {Num1} por {Num2} é " + (Num1 / Num2) + "\n";
        }
    }
}
