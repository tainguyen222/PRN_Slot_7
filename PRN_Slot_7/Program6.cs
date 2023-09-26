using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot_75
{
    public delegate void PrintDetails(string msg);
   
    class Program6

    {
        event PrintDetails Print;
        void Show(string msg)=> Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            Program6 p = new Program6();
            p.Print += new PrintDetails(p.Show);
            p.Print("Hello World !");
            Console.ReadLine();
        }

    }
}
