using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_Condicionais_Compras.Entities
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
 
        public List<Product> orders = new List<Product>();


        public void AddItem(Product product)
        {
            orders.Add(product);

        }

        public void removeItem(Product product)
        {
            orders.Remove(product);
        }

        public double ValorTotal()
        {
            double sum = 0;
            foreach (Product product in orders)
            { 
                sum += product.ValorProdutoIndividual;
            }
           
            return sum;
        }

        public void ShowProducts()
        {
            foreach (Product product in orders)
            {
                double valorTotal = ValorTotal();
                Console.WriteLine($"{product.name} - Quantity: {product.quantityProduct} - Subtotal: {product.ValorProdutoIndividual}");
            }
       
            double valor = ValorTotal();
            Console.Write("Total order: " + valor);


        }
    }
}
