using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_membrosEstaticos
{
    internal class Compra
    {
        public static double imposto = 6.0;

        public static double valorASerPago(double valorDolar, double valorDesejadoCompra)
        {
            double resultado = valorDolar * valorDesejadoCompra * (1 + (imposto/100));
            return resultado;
        }
    }
}
