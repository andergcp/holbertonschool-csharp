using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
            int len = array.Length;
            string sep = "";
            for (var i = len - 1; i >= 0; i--)
            {
                Console.Write($"{sep}{array[i]}");
                sep = " ";
            }
            Console.WriteLine();
        }
    }
}
