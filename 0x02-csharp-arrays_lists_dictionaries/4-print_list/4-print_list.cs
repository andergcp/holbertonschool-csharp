using System;
using System.Collections.Generic;


class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            var newList = new List<int>();
            string sep = "";
            for (var i = 0; i < size; i++)
            {
                newList.Add(i);
                Console.Write($"{sep}{i}");
                sep = " ";
            }
            Console.WriteLine();
            return newList;
        }
    }
}
