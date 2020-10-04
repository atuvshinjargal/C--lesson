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
            double x=3, y=5;
            bool a = x == y; //a=false;
            Console.WriteLine(a);
            a = x != y; //x,y 2 tencuu bish uu?
            Console.WriteLine(a); //a=true;
            a = x < y; //a=true; //x baga uu?
            Console.WriteLine(a);
            a = x > y; //a=false; //x ih uu?
            Console.WriteLine(a);
            a = x <= y; //a=true; x baga buyu tencuu yu?
            Console.WriteLine(a);
            a = x >= y; //a=false; //x ih buyu tencuu yu?
            Console.WriteLine(a);
        }
    }
}
