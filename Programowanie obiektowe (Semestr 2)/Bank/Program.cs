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
            int i, j;
            int[] tab = new int[100];
            string caseSwitch;
            double suma = 0.0;
            Bank x = new Bank();
            List<Klient> klienci = new List<Klient>();
            Konto[,] konta = new Konto[100,3];
            Firma firma1 = new Firma("firma1","1234");
            DuzaFirma duzafirma1 = new DuzaFirma("duzafirma1", "5678");
            Osoba osoba = new Osoba("Piotr", "Awramiuk", "98021804523");
            WaznaOsoba waznaosoba = new WaznaOsoba("Michał", "Szorc", "98071604559");
            x.dodajKlienta(firma1);
            x.dodajKlienta(duzafirma1);
            x.dodajKlienta(osoba);
            x.dodajKlienta(waznaosoba);
            klienci = x.getKlienci();
            Konto y1 = new Konto("123456789");
            Konto y2 = new Konto("234567890");
            Konto y3 = new Konto("345678901");
            Konto y4 = new Konto("456789012");
            Konto y5 = new Konto("567890123");
            Konto y6 = new Konto("678901234");
            Konto y7 = new Konto("789012345");
            konta[0, 0] = y1;
            tab[0]++;
            konta[0, 1] = y2;
            tab[0]++;
            konta[1, 0] = y3;
            tab[1]++;
            konta[2, 0] = y4;
            tab[2]++;;
            konta[3, 0] = y5;
            tab[3]++;
            konta[3, 1] = y6;
            tab[3]++;
            konta[3, 2] = y7;
            tab[3]++;
            konta[0, 0].wplac(3000);
            konta[0, 1].wplac(2000);
            konta[1, 0].wplac(5000);
            konta[2, 0].wplac(6000);
            konta[3, 0].wplac(10000);
            konta[3, 1].wplac(2000);
            konta[3, 2].wplac(3000);
            while (true)
            {
                suma = 0.0;
                Console.WriteLine("1 - łączne środki na kontach wszystkich firm");
                Console.WriteLine("2 - łączne środki na kontach wszystkich osób fizycznych");
                Console.WriteLine("3 - łączne środki na kontach wszystkich dużych firm i ważnych osób łącznie");
                Console.WriteLine("4 - łączne środki na kontach wszystkich zwykłych osób");
                caseSwitch = Console.ReadLine();
                switch(caseSwitch)
                {
                    case "1":
                        for (i = 0; i < klienci.Count; i++)
                        {
                            if (klienci[i].GetType() == firma1.GetType())
                            {
                                for (j = 0; j < tab[i]; j++)
                                {
                                    suma += konta[i, j].getSaldo();                                   
                                }
                            }
                        }
                        Console.WriteLine(suma);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        for (i = 0; i < klienci.Count; i++)
                        {
                            if (klienci[i].GetType() == osoba.GetType() || klienci[i].GetType() == waznaosoba.GetType())
                            {
                                for (j = 0; j < tab[i]; j++)
                                {
                                    suma += konta[i, j].getSaldo();
                                }
                            }
                        }
                        Console.WriteLine(suma);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        for (i = 0; i < klienci.Count; i++)
                        {
                            if (klienci[i].GetType() == duzafirma1.GetType() || klienci[i].GetType() == waznaosoba.GetType())
                            {
                                for (j = 0; j < tab[i]; j++)
                                {
                                    suma += konta[i, j].getSaldo();
                                }
                            }
                        }
                        Console.WriteLine(suma);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        for (i = 0; i < klienci.Count; i++)
                        {
                            if (klienci[i].GetType() == osoba.GetType())
                            {
                                for (j = 0; j < tab[i]; j++)
                                {
                                    suma += konta[i, j].getSaldo();
                                }
                            }
                        }
                        Console.WriteLine(suma);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
