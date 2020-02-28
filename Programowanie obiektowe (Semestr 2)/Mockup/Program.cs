using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8.mockup;
using ConsoleApp8.kartoteka;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string caseSwitch;
            string imie, nazwisko;
            Osoba osoba;
            Kartoteka Lista = new Kartoteka();
            while (true)
            {
                Console.WriteLine("1 - dodaj osobe do kartoteki");
                Console.WriteLine("2 - usun osobe z kartoteki");
                Console.WriteLine("3 - wyswietla rozmiar kartoteki");
                Console.WriteLine("4 - sprawdzasz czy osoba juz jest w kartotece");
                Console.WriteLine("5 - wypisz z kartoteki");
                caseSwitch = Console.ReadLine();
                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("Podaj imie: ");
                        imie = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        nazwisko = Console.ReadLine();
                        osoba = new Osoba(imie, nazwisko);
                        Lista.dodaj(osoba);
                        break;
                    case "2":
                        Console.WriteLine("Podaj imie: ");
                        imie = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        nazwisko = Console.ReadLine();
                        osoba = new Osoba(imie, nazwisko);
                        Lista.usun(osoba);
                        break;
                    case "3":
                        Console.WriteLine(Lista.rozmiar());
                        break;
                    case "4":
                        Console.WriteLine("Podaj imie: ");
                        imie = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko: ");
                        nazwisko = Console.ReadLine();
                        osoba = new Osoba(imie,nazwisko);
                        Console.WriteLine(Lista.czyZawiera(osoba));
                        break;
                    case "5":
                        int x;
                        Console.WriteLine("Podaj numer pozycji :");
                        x = Convert.ToInt32(Console.ReadLine());
                        osoba = Lista.pobierz(x);
                        Console.WriteLine(osoba.getImie());
                        Console.WriteLine(osoba.getNazwisko());
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
