using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Punkt p1 = new Punkt(0,0), p2 = new Punkt(1,0), p3 = new Punkt(1,1), p4 = new Punkt(0,1);
            string kolor = "zielony";
            Trojkat t = new Trojkat(kolor, p1, p2, p3);
            Czworokat c = new Czworokat(kolor, p1, p2, p3, p4);
            Prostokat p = new Prostokat(kolor, p2, p4);
            Kwadrat k = new Kwadrat(kolor, p1, a);
            Console.WriteLine(t.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(p.ToString());
            Console.WriteLine(k.ToString());
            Console.ReadKey();


        }
    }
}
