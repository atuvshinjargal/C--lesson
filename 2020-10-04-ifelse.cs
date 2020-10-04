using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; string s;
            Console.WriteLine("X toog oruulna uu.");
            s = Console.ReadLine(); // garaas zuvhun strig turuld unshina.
            x = Convert.ToInt32(s); //string -g too bolgon hurvuulne.
            if (x<10) //end nuhtsul shalgana. ened tohioldol x<10 gej shalgaj baina.
            {//ene haaltan dotor nuhtsul bielej baigaa ued hiih uildeliig bichne.
                Console.WriteLine("10-s baga baina.");
            }
            else
            { //ene haaltan dotor esreg tohioldold hiih uildeliig bichne.
                Console.WriteLine("10-s ih buyu tencuu baina.");
            }
        }   
    }
}
