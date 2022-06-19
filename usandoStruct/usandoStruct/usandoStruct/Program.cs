namespace usandoStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p; //Pode instanciar assim
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);


            p = new Point(); // ou assim

            Console.WriteLine(p);
        }
    }
}