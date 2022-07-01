using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_Condicionais_Compras.Entities
{
    public class Exercise : Order
    {
        Client cliente = new Client();

        public void Menu()
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            cliente.name = nameClient;
            Console.Write("Email: ");
            string emailClient = Console.ReadLine();
            cliente.email = emailClient;
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDateClient = DateTime.Parse(Console.ReadLine());
            cliente.birthDate = birthDateClient;

            Console.WriteLine("Enter order data:");
            //Console.Write("Status: ");
            //int statusOrder = int.Parse(Console.ReadLine());
            //order.status = (OrderStatus)statusOrder;
            Console.Write("How many items to this order? ");
            int quantityItem = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityItem; i++)
            {
                Product product = new Product();

                DateTime dateNow = DateTime.Now;
                moment = dateNow;
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                product.name = nameProduct;
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                product.price = priceProduct;
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                product.quantityProduct = quantity;
                double valorPorQuant = product.valorTotalPorQuant();
                product.ValorProdutoIndividual = valorPorQuant;
                orders.Add(product);

            }


            Console.WriteLine($"ORDER SUMMARY " + Environment.NewLine +
                $"Order moment: {moment} " + Environment.NewLine +
                $"Client: {cliente.name}" + Environment.NewLine +
                $"Bithdate Client: {cliente.birthDate}" + Environment.NewLine +
                $"Email Client: {cliente.email}" + Environment.NewLine +
                $"Order Items:");
               ShowProducts();


        }

       
    }
}
