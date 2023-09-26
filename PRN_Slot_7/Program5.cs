using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot_74
{
    class Program5
    {
        static int sum(int x, int y) => x + y;
        static void Print(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            int a = 15;
            int b = 25;
            int s;
            string strResult;

            Func<int, int, int> sumFunc = sum;
            s= sumFunc(a, b);
            strResult = $"{a}+{b}={s}";
            Console.WriteLine("****invoke Print method by Action delegate***");
            Action<string> action = Print;
            action(strResult);
            Console.ReadLine();

        }

    }
}
