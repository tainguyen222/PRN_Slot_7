using PRN_Slot_7_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot_73
{
     class Program3
    {
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            MyDelegate MyDele01 = MyClass.Print;
            MyDelegate MyDele02 = MyClass.Show;
            Console.WriteLine("***Combies MyDele01+MyDele02****");
            MyDelegate MyDele = MyDele01+MyDele02;
            MyDele(msg);
            Console.WriteLine("***Combies MyDele01+MyDele02+MyDele03****");
            MyDelegate MyDele03 = MyClass.Display;
            MyDele += MyDele03;
            MyDele(msg);
            Console.WriteLine("________________________");
            Console.WriteLine("***Remove MyDele02****");
            MyDele -= MyDele02;
            MyDele("Hello World !");
            Console.ReadLine();
        }
    }
}
