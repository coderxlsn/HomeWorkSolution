using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsoleBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt =  DateTime.Now;
            ;
            Console.WriteLine("Сейчас {0}, {1}",dt.ToLongDateString(), dt.ToLongTimeString());
            Console.ReadKey();
        }
    }
}
