using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % 10;
        string message;
        if (lastDigit > 5)
        {
            message = "and is greater than 5";
        }
        else if (lastDigit < 6 && lastDigit != 0)
        {
            message = "and is less than 6 and not 0";
        }
        else
        {
            message = "and is 0";
        }
        Console.WriteLine($"The last digit of {number} is {lastDigit} {message}");
    }
}
