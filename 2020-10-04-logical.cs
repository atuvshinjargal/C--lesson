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
            bool a = (x == y) && (x<y); //AND hoyul bielesen baih 
            //3==5 uchraas false 3<5 uchraas true
            Console.WriteLine(a); //a=false;
            a = (x == y) || (x < y); //OR esvel ali neg bielsen ued true
            //3==5 ->false || 3<5 ->true
            Console.WriteLine(a); //a=true;
            a = !(x == y); //!(3==5 false) => true;
            Console.WriteLine(a); //a=true;
            // ! baival false->true; true->false;
        }
    }
}
