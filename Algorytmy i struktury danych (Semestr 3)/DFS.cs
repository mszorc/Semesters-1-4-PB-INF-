using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static bool[] visited;
        public static int n;
        public static int[,] A; 
        public static string output;
        public static int zliczanko = 0;
        static void DFS(int v)
        {

            int i;
            visited[v] = true;     // Zaznaczamy węzeł jako odwiedzony
            output = output + Convert.ToString(v + 1) + " " ;
            zliczanko++;
            // Rekurencyjnie odwiedzamy nieodwiedzonych sąsiadów
            for (i = 0; i < n; i++) if ((A[v, i] == 1) && !visited[i]) DFS(i);
        }
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("In0205.txt");
            StreamWriter out_file = new StreamWriter("Out0205.txt");
            n = Convert.ToInt32(in_file.ReadLine());
            A = new int[n, n];
            string x;
            string[] split;
            visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                visited[i] = false;
            }
            for (int i = 0; i < n; i++)
            {
                x = in_file.ReadLine();
                split = x.Split(new Char[] { ' ' });
                for (int j = 0; j < split.Length; j++)
                {
                    A[i, Convert.ToInt32(split[j]) - 1] = 1;
                }
            }
            DFS(0);
            if (zliczanko == n)
            {
                out_file.WriteLine("Graf jest spójny");
                out_file.WriteLine(output);
            }
            else out_file.WriteLine("Graf nie jest spójny"); 
            in_file.Close();
            out_file.Close();
        }
    }
}
