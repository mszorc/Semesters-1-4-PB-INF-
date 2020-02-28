using System;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generowanie pliku tekstowego
            int i;
            /*int q = 1000, y;
            Random rnd = new Random();
            StreamWriter out_file_pom = new StreamWriter("in.txt");
            out_file_pom.WriteLine(q);
            for (i = 0; i < q; i++)
            {
                y = rnd.Next(1, 1000);
                out_file_pom.WriteLine(y);
            }
            out_file_pom.Close();*/
            //Kod właśćiwy
            StreamReader in_file = new StreamReader("in.txt");
            string[] nf = File.ReadAllLines("in.txt");
            in_file.Close();
            int file_size = Int32.Parse(nf[0]);
            int[] x = new int[file_size];
            int output = 0, output2 = 0;
            int licznik_operacji1 = 0, licznik_operacji2 = 0;
            bool z = true, z2= false;           
            for (i = 1; i <= file_size ; i++)
            {
                x[i-1] = Int32.Parse(nf[i]); //Wypełnianie tablicy liczbami z pliku
            }
            int max_x = x.Max();
            int[] t = new int[8128 * max_x]; //Tablica zliczająca liczbę liczb
            int f = 1;
            for (i = 0; i < x.Length; i++)
            {
                t[x[i]]++;
                licznik_operacji1++;
            }
            //Algorytm optymalny
            while (z == true)
            {
                output = 0;
                z = false;
                for (i = 0; i <=max_x * f; i++)
                {
                    
                    if (t[i] > 1)
                    {
                        z = true; //zmienia na true, bo znaleźliśmy liczbę powtarzającą się
                        if (i >= 0.5 * max_x * f) z2 = true;
                        t[2 * i] += t[i] / 2; //2*i - wynik sumowania
                        t[i] = t[i] % 2; //0 lub 1, zależy czy 'i' parzyste
                    }
                    if (t[i] == 1)
                    {
                        output++;
                    }
                    licznik_operacji1++;
                }
                if (max_x * f * 2 < t.Length && z2==true) f *= 2; //zwiększamy zakres, aby nie wyjść poza niego
            }
            StreamWriter out_file = new StreamWriter("out.txt");
            out_file.WriteLine(output);
            Console.WriteLine(licznik_operacji1);
            //Algorytm naiwny
            z = true;
            int j = 0;
            while (z == true)
            {
                z = false;
                for (i = j; i < x.Length; i++)
                {
                    if (x[i] == x[j] && i != j && x[i] > 0)
                    {
                        x[i] = -1;
                        x[j] *= 2;
                        z = true;
                        //i = 0;
                        j = 0;
                    }
                    licznik_operacji2++;
                }
               if (z == false && j != file_size - 1)
               {
                    j++;
                    z = true;
               }
            } 
            for (i=0;i<x.Length;i++)
            {
                if (x[i] > 0) output2++;
            }
            out_file.WriteLine(output2);
            out_file.Close();
            Console.WriteLine(licznik_operacji2);
        }
    }
}
