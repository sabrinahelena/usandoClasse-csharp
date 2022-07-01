using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_Condicionais_Compras.Entities
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public double quantityProduct { get; set; }
        public double ValorProdutoIndividual { get; set; }
        public double ValorTotalProdutos { get; set; }

        public double valorTotalPorQuant()
        {
            return quantityProduct * price;
        }

    }

    

}
