using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            var sep = "";
            for (var i = 0; i < 100; i++)
            {
                Console.Write($"{sep}{i:D2}");
                sep = ", ";
            }
        }
    }
}
