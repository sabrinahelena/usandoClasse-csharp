/* 
 * O nullable é usado para dados e parâmetros opcionais em struct
 * 
 */

namespace usandoNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null; //pode fazer assim
            double? y = null;//ou assim
            double? z = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //pega o valor X ou o valor default que é 0 
            Console.WriteLine(z.GetValueOrDefault()); //pega o valor X ou o valor default do nulo que é 10 


            double a = x ?? 1; //joga o valor de X em A mas se for nulo, joga 1
            double b = z ?? 2; //joga o valor de X em A mas se for nulo, joga 2

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}