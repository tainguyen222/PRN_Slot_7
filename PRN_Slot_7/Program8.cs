﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot_78
{
    class Program8
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            foreach (string name in names.OrderBy(s=>s))
            {
                Console.WriteLine(name);

            }
            Console.ReadLine();
        }
    }
}
