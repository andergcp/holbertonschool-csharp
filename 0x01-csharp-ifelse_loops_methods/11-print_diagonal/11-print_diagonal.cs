using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
            for (var i = 0; i < length; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("\\\n");
            }
        Console.Write("\n");
    }
}
