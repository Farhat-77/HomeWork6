﻿using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt = false;
            int start = 0, end = 1;
            while (!isInt)
            {
                Console.Write("End: ");
                isInt = int.TryParse(Console.ReadLine(), out start);
            }
            isInt = false;
            while (!isInt)
            {
                Console.Write("End: ");
                isInt = int.TryParse(Console.ReadLine(), out end);
            }

            RangeOfArray array = new RangeOfArray(start, end);

            for (int i = start; i <= end; i++)
            {
                array[i] = 5;
                Console.WriteLine("array[{0}] - {1}", i, array[i]);
            }

            Console.ReadLine();
        }
    }
}

