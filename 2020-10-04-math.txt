using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, x=3, y=5;
            s = Math.Max(x, y); // x, y -iin ihiig olno.
            // s=y bolno. -> s=5;
            Console.WriteLine(s);
            s = Math.Min(x, y); //x, y -iin bagiig olno.
            //s=x bolno -> s=3;
            Console.WriteLine(s);
            s = Math.Sqrt(x); //x-s yazguur avna.
            Console.WriteLine(s); //s=1.7 orchim garna.
            s = Math.Abs(x-10); //x-s modul avna. x-10=-7;
            Console.WriteLine(s);//s=|x|; s=7; bolno.
            s = Math.Round(x + 0.6); //Oirolcooloh x=3+0.6=3.6
            //0.5 deesh bol deeshee 
            //0.5 baga bol dooshoo
            Console.WriteLine(s); //Round(3.6)->4 bolno.
        }
    }
}
