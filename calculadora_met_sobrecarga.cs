using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    public class calculadora_met_sobrecarga
    {

        public calculadora_met_sobrecarga()
        {
        }

        public int calcular(int a, int b)
        {
            return a * b;
        }

        public int calcular(int a, int b, int c)
        {
            return a * b * c;
        }


        public double calcular(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }

        public double calcular(double a, double b, bool esPotencia)
        {
            return Math.Pow(a, b);
        }

        public int calcular(int baseNum, int exponente, bool esPotencia)
        {
            return (int)Math.Pow(baseNum, exponente);
        }

    }
}
