using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kruskal2
{
    public class Przedmiot
    {
        public int wartosc;
        public int waga;
        public Przedmiot()
        {
            wartosc = 0;
            waga = 0;

        }
    }
    public class Tablica_plecakowa
    {
        public int wartosc;
        public bool czy_wziety;
        public Tablica_plecakowa()
        {
            wartosc = 0;
            czy_wziety = false;
        }
    }
    
    public class Program
    {
        public static void plecakowy(Przedmiot[] przedmioty, int W, StreamWriter out_file)
        {
            Tablica_plecakowa[,] tab = new Tablica_plecakowa[W + 1, przedmioty.Length];
            int max = 0, licznik = 0;
            bool pom = false;
            for (int i = 0; i < W + 1; i++)
            {
                for (int j = 0; j < przedmioty.Length; j++)
                {
                    tab[i, j] = new Tablica_plecakowa();
                }
            }
            for (int i = 0; i < W + 1; i++)
            {
                for (int j = 1; j < przedmioty.Length; j++)
                {
                    if (i < przedmioty[j].waga && i != 0)
                    {
                        tab[i, j].wartosc = tab[i, j - 1].wartosc;
                        tab[i, j].czy_wziety = false;
                    }
                    else if (i >= przedmioty[j].waga)
                    {
                        if (tab[i, j - 1].wartosc > tab[i - przedmioty[j].waga, j - 1].wartosc + przedmioty[j].wartosc)
                        {
                            tab[i, j].wartosc = tab[i, j - 1].wartosc;
                            tab[i, j].czy_wziety = false;
                        }
                        else
                        {
                            tab[i, j].wartosc = tab[i - przedmioty[j].waga, j - 1].wartosc + przedmioty[j].wartosc;
                            tab[i, j].czy_wziety = true;
                            if (max == tab[i, j].wartosc) licznik++;
                            else
                            {
                                licznik = 0;
                                max = tab[i, j].wartosc;
                            }
                        }
                    }
                }
            }
            List<string> odpowiedzi = new List<string>();
            for (int i = W; i >= 0; i--)
            {
                for (int j = przedmioty.Length - 1; j >= 0; j--)
                {
                    pom = false;
                    if (tab[i, j].wartosc == max && tab[i, j].czy_wziety == true)
                    {
                        int i1 = i, j1 = j;
                        string odpowiedz = "";
                        while (i1 != 0 && j1 != 0)
                        {
                            if (tab[i1, j1].czy_wziety == false) j1--;
                            else
                            {
                                odpowiedz = Convert.ToString(j1) + " " + odpowiedz;
                                i1 -= przedmioty[j1].waga;
                                j1--;
                            }
                        }
                        foreach (string x in odpowiedzi)
                        {
                            if (x.Equals(odpowiedz))
                            {
                                pom = true;
                                break;
                            }
                        }
                        if (pom == false)
                        {
                            odpowiedzi.Add(odpowiedz);
                            out_file.Write("{0} ", odpowiedz);
                        }
                        out_file.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("In0302.txt");
            StreamWriter out_file = new StreamWriter("Out0302.txt");
            string x;
            int W = 0, n = 0, i = 1;
            x = in_file.ReadLine();
            string[] split = x.Split(new char[] { ' ' });
            W = int.Parse(split[1]);
            n = int.Parse(split[0]);
            Przedmiot[] przedmioty = new Przedmiot[n + 1];
            for (int j = 0; j < n + 1; j++)
            {
                przedmioty[j] = new Przedmiot();
            }
            while ((x = in_file.ReadLine()) != null)
            {
                split = x.Split(new char[] { ' ' });
                przedmioty[i].wartosc = int.Parse(split[0]);
                przedmioty[i].waga = int.Parse(split[1]);
                i++;
            }
            plecakowy(przedmioty, W, out_file);
            in_file.Close();
            out_file.Close();
        }
    }
}
