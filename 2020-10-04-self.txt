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
            x += 3; //x=x+3; -> x=3+3; x=6;
            Console.WriteLine(x);
            x -= 2; //x=x-3; -> x=6-2; x=4;
            Console.WriteLine(x);
            x *= 3; //x=x*3; -> x=4*3; x=12;
            Console.WriteLine(x);
            x /= 5; //x=x/5; -> x=12/5; x=2.4;
            Console.WriteLine(x);
            x %= 2; //x=x%2; -> x=2.4%2; x=0.4;
            Console.WriteLine(x);
            int a = 3; //3->011;  2->10; 4->100;
            a &= 4; //a=a&3; a=2; ->10 2-riin urjeh (AND)
            Console.WriteLine(a);
            a = 3; //3->011, 4->100;
            a |= 4; //2 tiin nemeh uildel (OR gedeg uildel)
            Console.WriteLine(a); //a=111; ->7
            a ^= 3; //inverse
            Console.WriteLine(a);

        }
    }
}
