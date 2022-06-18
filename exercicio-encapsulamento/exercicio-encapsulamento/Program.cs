namespace exercicio_encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV Asus";
            Console.WriteLine(p);
        }
    }
}