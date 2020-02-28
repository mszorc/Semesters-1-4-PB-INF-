using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4
{
    class Program
    {
        public static int INF = 10000;
        public static void GetPath(int n, int m, int[] d, int[] p, int[,] tab)
        {
            bool[] S = new bool[n];
            bool[] Q = new bool[n];
            int GraphSize = n;
            for (int i=0;i<n;i++)
            {
                S[i] = false;
                Q[i] = true;
            }
            for (int i = 0; i < n; i++)
            {
                d[i] = INF;
                p[i] = -1;
            }
            d[m - 1] = 0;
            int min_distance = d[m - 1];
            int min_index = m - 1;
            while(GraphSize>0)
            {
                for (int i=0;i<n;i++)
                {
                    if (min_distance > d[i] && Q[i] == true) min_index = i;     
                }
                S[min_index] = true;
                Q[min_index] = false;
                for (int i = 0; i < n; i++)
                {
                    if (tab[min_index, i] != INF && d[i] > d[min_index] + tab[min_index, i])
                    {
                        d[i] = d[min_index] + tab[min_index, i];
                        p[i] = min_index + 1;
                    }
                }
                min_distance = INF;
                GraphSize--;
            }
        }
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("In0304.txt");
            StreamWriter out_file = new StreamWriter("Out0304.txt");
            string x = in_file.ReadLine();
            string[] split = x.Split(new Char[] { ' ', ';', ',' });
            int n = Convert.ToInt32(split[0]);
            int m = Convert.ToInt32(split[1]);
            int[,] tab = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                x = in_file.ReadLine();
                split = x.Split(new Char[] { ' ', ';', ',' });
                for (int j = 0; j < n; j++)
                {
                    tab[i, j] = Convert.ToInt32(split[j]);
                }
            }
            int[] dist = new int[n];
            int[] pred = new int[n];
            int[,] tab2 = new int[n, n];
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    tab2[i, j] = tab[j, i];
                }
            }
            GetPath(n, 6, dist, pred, tab2);
            out_file.Write("dist[");
            for (int i=0;i<n-1;i++)
            {
                out_file.Write("{0} ", dist[i]);
            }
            out_file.Write("{0}]", dist[n - 1]);
            out_file.WriteLine();
            out_file.Write("pred[");
            for (int i = 0; i < n - 1; i++)
            {
                out_file.Write("{0} ", pred[i]);
            }
            out_file.Write("{0}]", pred[n - 1]);
            in_file.Close();
            out_file.Close();
        }
    }
}
