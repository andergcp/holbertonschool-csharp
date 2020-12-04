using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            var newArray = new int[size];
            string sep = "";
            for (var i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i;
                Console.Write($"{sep}{i}");
                sep = " ";
            }
            Console.WriteLine();
            return newArray;
        }
    }
}
