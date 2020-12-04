using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sep = "";
            for (var i = 0; i <= 9; i++)
            {
                for (var j = 0; j <= 9; j++)
                {
                    if (j > i)
                    {
                        Console.Write($"{sep}{i}{j}");
                        sep = ", ";
                    }
                }
            }
            Console.Write("\n");
        }
    }
}
