﻿using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 99; i++)
                Console.Write("{0} = 0X{0:x} \n", i);
        }
    }
}