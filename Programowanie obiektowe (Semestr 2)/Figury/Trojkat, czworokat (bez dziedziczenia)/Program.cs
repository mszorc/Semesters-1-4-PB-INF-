using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string caseSwitch;
            Punkt p1, p2, p3, p4;
            Linia l1, l2, l3, l4;
            Trojkat t;
            Czworokat c;
            string xx, yy;
            int x, y,i;
            Obraz trojkaty = new Obraz();
            Obraz czworokaty = new Obraz();
            while (true)
            {
                Console.WriteLine("1 - dodaj trojkat do listy");
                Console.WriteLine("2 - dodaj czworokat do listy");
                Console.WriteLine("3 - wyswietl trojkaty z listy");
                Console.WriteLine("4 - wyswietl czworokaty z listy");
                Console.WriteLine("5 - przesun trojkat");
                Console.WriteLine("6 - przesun czworokat");
                caseSwitch = Console.ReadLine();
                switch(caseSwitch)
                {
                    case "1":
                        Console.WriteLine("Podaj trzy punkty");
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p1 = new Punkt(x, y);
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p2 = new Punkt(x, y);
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p3 = new Punkt(x, y);
                        l1 = new Linia(p1, p2);
                        l2 = new Linia(p2, p3);
                        l3 = new Linia(p3, p1);
                        t = new Trojkat(l1, l2, l3);
                        trojkaty.dodajtrojkat(t);
                        break;
                    case "2":
                        Console.WriteLine("Podaj cztery punkty");
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p1 = new Punkt(x, y);
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p2 = new Punkt(x, y);
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p3 = new Punkt(x, y);
                        xx = Console.ReadLine();
                        yy = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        y = Convert.ToInt32(yy);
                        p4 = new Punkt(x, y);
                        l1 = new Linia(p1, p2);
                        l2 = new Linia(p2, p3);
                        l3 = new Linia(p3, p4);
                        l4 = new Linia(p4, p1);
                        c = new Czworokat(l1, l2, l3,l4);
                        czworokaty.dodajczworokat(c);
                        break;
                    case "3":
                        Console.WriteLine("Podaj numer indeksu:");
                        xx = Console.ReadLine();
                        i = Convert.ToInt32(xx);
                        t = trojkaty.zwroc_trojkat(i);
                        Console.WriteLine(t.ToString());
                        break;
                    case "4":
                        Console.WriteLine("Podaj numer indeksu:");
                        xx = Console.ReadLine();
                        i = Convert.ToInt32(xx);
                        c = czworokaty.zwroc_czworokat(i);
                        Console.WriteLine(c.ToString());
                        break;
                    case "5":
                        Console.WriteLine("Podaj indeks trojkata");
                        xx = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        t = trojkaty.zwroc_trojkat(x);
                        Console.WriteLine("Podaj wartosci przesuniecia");
                        xx = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        yy = Console.ReadLine();
                        y = Convert.ToInt32(yy);
                        t.przesun(x, y);
                        break;
                    case "6":
                        Console.WriteLine("Podaj indeks czworokata");
                        xx = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        c = czworokaty.zwroc_czworokat(x);
                        Console.WriteLine("Podaj wartosci przesuniecia");
                        xx = Console.ReadLine();
                        x = Convert.ToInt32(xx);
                        yy = Console.ReadLine();
                        y = Convert.ToInt32(yy);
                        c.przesun(x, y);
                        break;
                }
            }
        }
    }
}
