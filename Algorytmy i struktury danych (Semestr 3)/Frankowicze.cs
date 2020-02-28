using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace _1
{

    public class Bank
    {
        public int nrBanku;
        public int d;
        public int f;
        public bool odwiedzony = false;
        public Bank(int x)
        {
            nrBanku = x;
        }
    }
    class Program
    {
        static int czas = 0;
        static List<Bank>[] G1;
        static List<Bank>[] G;
        static List<List<Bank>> skladowe_silne;
        static List<Bank> pom_lista;
        public static void DFS(Bank bank)
        {
            if (bank.odwiedzony == false)
            {
                czas++;
                bank.d = czas;
                bank.odwiedzony = true;
                foreach (Bank bank_sasiedni in G[bank.nrBanku - 1])
                {
                    if (bank_sasiedni.odwiedzony == false)
                    {
                        DFS(bank_sasiedni);
                    }
                }
                czas++;
                bank.f = czas;
            }
        }
        public static void DFS2(Bank bank)
        {
            if (bank.odwiedzony == false)
            {
                if (pom_lista == null) pom_lista = new List<Bank>();
                pom_lista.Add(bank);
                czas++;
                bank.d = czas;
                bank.odwiedzony = true;
                foreach (Bank bank_sasiedni in G1[bank.nrBanku - 1])
                {
                    if (bank_sasiedni.odwiedzony == false)
                    {
                        DFS2(bank_sasiedni);
                    }
                }
                czas++;
                bank.f = czas;
            }
        }
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("In0501.txt");
            StreamWriter out_file = new StreamWriter("Out0501.txt");
            string x = in_file.ReadLine();
            string[] split = x.Split(new Char[] { ' ' });
            int n = Convert.ToInt32(split[0]);   //liczba bankow
            int m = Convert.ToInt32(split[1]);   //wsploczynnik bezpieczenstwa
            double CHF = Convert.ToDouble(split[2]);   //cena franka
            double EUR = Convert.ToDouble(split[3]);   //cena euro
            int k = Convert.ToInt32(split[4]);   //numer banku Bk
            int t = Convert.ToInt32(split[5]);   //numer banku Bt
            double[,] SR = new double[n, n];   //tablica stopni ryzyka
            double CHF_EUR = CHF - EUR;   //różnica w cenie franka i euro
            for (int i = 0; i < n; i++)
            {
                x = in_file.ReadLine();
                split = x.Split(new Char[] { ' ' });
                for (int j = 0; j < n; j++)
                {
                    SR[i, j] = Convert.ToDouble(split[j]);
                }
            }
            Bank[] tablica_bankow = new Bank[n];
            for (int i = 0; i < n; i++)
            {
                tablica_bankow[i] = new Bank(i + 1);
            }
            G = new List<Bank>[n];
            for (int i = 0; i < n; i++)
            {
                G[i] = new List<Bank>();
                for (int j = 0; j < n; j++)
                {
                    if (m * (1 - SR[i, j]) > CHF_EUR)
                    {
                        G[i].Add(tablica_bankow[j]);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                DFS(tablica_bankow[i]);
            }
            Bank[] posortowana_tablica_bankow = tablica_bankow.OrderByDescending(c => c.f).ToArray();
            //transpozycja
            G1 = new List<Bank>[n];
            for (int i = 0; i < n; i++)
            {
                G1[i] = new List<Bank>();
            }
            for (int i = 0; i < n; i++)
            {
                foreach (Bank bank in G[i])
                {
                    G1[bank.nrBanku - 1].Add(tablica_bankow[i]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                posortowana_tablica_bankow[i].odwiedzony = false;
                posortowana_tablica_bankow[i].d = 0;
                posortowana_tablica_bankow[i].f = 0;
            }
            czas = 0;
            skladowe_silne = new List<List<Bank>>();
            //DFS na grafie po transpozycji
            for (int i = 0; i < n; i++)
            {
                if (posortowana_tablica_bankow[i].odwiedzony == false)
                {
                    pom_lista = null;
                    DFS2(posortowana_tablica_bankow[i]);
                    skladowe_silne.Add(pom_lista);
                }
            }
            bool czy_wypisane = false;
            foreach (List<Bank> banki in skladowe_silne)
            {
                foreach (Bank bank in banki)
                {
                    if (bank.nrBanku == k)
                    {
                        foreach (Bank bank1 in banki) out_file.Write(bank1.nrBanku + " ");
                        czy_wypisane = true;
                    }
                    break;
                }
                if (czy_wypisane == true) break;
            }
            out_file.WriteLine();
            czy_wypisane = false;
            foreach (List<Bank> banki in skladowe_silne)
            {
                foreach (Bank bank in banki)
                {
                    if (bank.nrBanku == t)
                    {
                        foreach (Bank bank1 in banki) out_file.Write(bank1.nrBanku + " ");
                        czy_wypisane = true;
                    }
                    break;
                }
                if (czy_wypisane == true) break;
            }
            out_file.Close();
            in_file.Close();
        }
    }
}
