using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        string splited = str.Substring(0, 9);
        Console.WriteLine("{0}{0}{0}", str);
        Console.WriteLine($"{splited}");
    }
}