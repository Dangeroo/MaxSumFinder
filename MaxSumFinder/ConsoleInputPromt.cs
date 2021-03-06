﻿using MaxSumFinder.Interfaces;
using System;

namespace MaxSumFinder
{
    public class ConsoleInputPromt : IInputPromt
    {
        public string FilePath { get; set; }

        public string InputPromt()
        {
            Console.WriteLine(new string('#', 50));
            Console.WriteLine("     This program can output the number of\n     line in which the sum of elements is max");
            Console.WriteLine(new string('#', 50));
            Console.WriteLine();
            Console.WriteLine(@"Please, input the path to your text file (format is C:\\textfile.txt): ");
            FilePath = Console.ReadLine();
            Console.WriteLine();
            return FilePath;
        }
    }
}
