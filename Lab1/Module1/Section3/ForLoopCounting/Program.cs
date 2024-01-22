using System.ComponentModel.DataAnnotations;

namespace ForLoopCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 5; x++) {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(i);
                }

                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}
