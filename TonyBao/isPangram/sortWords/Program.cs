﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortWords
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Array.Sort(args, (x, y) => x.Length.CompareTo(y.Length));
            Console.Write(string.Join(" ", args));
        }
    }
}
