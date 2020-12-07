using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] newArray = new int[5, 5];
            newArray[2, 2] = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4)
                        Console.Write(newArray[i, j] + " ");
                    else
                        Console.Write(newArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
