using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int len = array.Length;
        if (index < 0 || index >= len)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        else
        {
            return array[index];
        }
    }
}
