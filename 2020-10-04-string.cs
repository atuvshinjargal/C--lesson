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
            string s = "Hello"; //s gedeg string turliin class uusne.
            string c = " bat";
            // s.Length bol stringiin urtiig todorhoilno.
            Console.WriteLine(s.Length); //urt n 5 baina.
            //Buh usgiig tom usgeer solino. (ToUpper())
            Console.WriteLine(s.ToUpper());//HELLO gej hevlene.
            //Buh usgiig jijig usgeer solino.
            Console.WriteLine(s.ToLower());//hello gej hevlene.
            //string -g zalgahdaa + temdeg ashiglana.
            Console.WriteLine(s + c);
            //2 stringiig zalgah uildel hiij baina.
            string name = string.Concat(s, c);
            Console.WriteLine(name);// Hello bat
            string text = $"Minii neriig {c} gedeg.";
            //Minii neriig bat gedeg. gej hevlene.
            Console.WriteLine(text);
            //Hello -n 0 dugaartai temdegt bol H useg yum.
            Console.WriteLine(s[0]); //H gej hevlegdene.
            // e usgiin string dotorh dugaariig hevlene.
            Console.WriteLine(s.IndexOf('e'));
            //Hello, 01234 e useg 1 dugaartai.
            //herev olon e useg baival ehnii dugaariig ilgeene.
            Console.WriteLine("\"Erdent uildver\" TUUG");
            // "-g string turuld oruulahiin tuld \" gej oruulna.
            Console.WriteLine("Dooshoo har \n\n\n");
            // \n -n shine mur uusgedeg.
            // \t -n tab zai (dogol mur) avna. 
            // \b -n hooson zai avna.
        }   
    }
}
