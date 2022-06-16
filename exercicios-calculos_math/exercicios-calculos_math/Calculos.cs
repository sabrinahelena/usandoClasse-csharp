using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_calculos_math
{
    internal class Calculos
    {
        public double valorA;
        public double valorB;
        public double valorC;
        public double valorD;
        public double raio;
        protected double pi = 3.14159;

        public double areaCirculo(double raio)
        {
            return pi * (Math.Pow(raio, 2));
        }

        public double calcularDiferenca(double valorA, double valorB, double valorC, double valorD)
        {
            return ((valorA * valorB) - (valorC * valorD));
        }

    }
}
