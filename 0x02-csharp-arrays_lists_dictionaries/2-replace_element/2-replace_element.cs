using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        var len = array.Length;
        if (index < 0 || index >= len)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        else
        {
            array[index] = n;
            return array;
        }
    }
}
