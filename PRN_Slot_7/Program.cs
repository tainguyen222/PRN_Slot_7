﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot_7
{
    public delegate int MyDelegate(int numOne, int numTwo);
     class Program
    {
        static int Add(int numOne, int numTwo) => numOne+numTwo;
        static int Subtract(int numOne, int numTwo)=> numOne-numTwo;
        static void Main(string[] args)
        {
            int n1 = 25;
            int n2 = 15;
            int result;
            MyDelegate obj1 = new MyDelegate(Add);
            result = obj1(n1,n2);
            Console.WriteLine($"{n1}+{n2}={result}");
            MyDelegate obj2 = Subtract;
            result = obj2(n1,n2);
            result= obj2.Invoke(n1,n2);
            Console.WriteLine($"{n1}-{n2}={result}");
            Console.ReadLine();
        }
    }
}
