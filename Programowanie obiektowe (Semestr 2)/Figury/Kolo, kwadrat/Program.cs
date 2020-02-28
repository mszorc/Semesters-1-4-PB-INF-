using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double ob1 = 0.0, ob2 = 0.0, ob3 = 0.0, po1 = 0.0, po2 = 0.0, po3 = 0.0;
            List<Figura> figury = new List<Figura>();
            Punkt p1 = new Punkt(1, 1);
            Kolo k1 = new Kolo(p1, 5);
            Kolo k2 = new Kolo(p1, 6);
            Kwadrat kw1 = new Kwadrat(p1, 5);
            Kwadrat kw2 = new Kwadrat(p1, 6);
            figury.Add(k1);
            figury.Add(k2);
            figury.Add(kw1);
            figury.Add(kw2);
            foreach (Figura x in figury)
            {
                x.Obwod();
                x.Pole();
                ob1 += x.zwrocObwod();
                po1 += x.zwrocPole();
            }
            Console.WriteLine("Obwod: {0}", ob1);
            Console.WriteLine("Pole: {0}", po1);
            foreach (Figura x in figury)
            {
                x.Przesun(2, 2);
                x.Obwod();
                x.Pole();
                ob2 += x.zwrocObwod();
                po2 += x.zwrocPole();
            }
            Console.WriteLine("Obwod po przesunieciu: {0}", ob2);
            Console.WriteLine("Pole po przesunieciu: {0}", po2);
            foreach (Figura x in figury)
            {
                x.Skaluj(2);
                x.Obwod();
                x.Pole();
                ob3 += x.zwrocObwod();
                po3 += x.zwrocPole();
            }
            Console.WriteLine("Obwod po skalowaniu: {0}", ob3);
            Console.WriteLine("Pole po skalowaniu: {0}", po3);
            Console.ReadKey();
        }
    }
}
