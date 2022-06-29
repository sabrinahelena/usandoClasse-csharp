using exercicio1_Condicionais_Posts.Entities;

namespace exercicio1_Condicionais_Posts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();

            exercise.DoPost();
            Console.WriteLine("----------------------------");
            exercise.DoComment();
        }
    }
}