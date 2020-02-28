using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    public class Edge
    {
        public int beg, end;
        public int weight;
        public Edge(int beg_, int end_, int weight_)
        {
            beg = beg_;
            end = end_;
            weight = weight_;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("In0303.txt");
            StreamWriter out_file = new StreamWriter("Out0303.txt");
            string x = in_file.ReadLine();
            string[] split = x.Split(new Char[] { ' ' });
            int n = Convert.ToInt32(split[0]);
            int m = Convert.ToInt32(split[1]);
            List<Edge> list = new List<Edge>();
            int num=0;
            for (int i = 0; i < n; i++)
            {
                x = in_file.ReadLine();
                split = x.Split(new Char[] { ' ' });
                num += split.Length / 2;
                for (int j=0;j<split.Length-1;j+=2)
                {
                    Edge e = new Edge(i+1, Convert.ToInt32(split[j]), Convert.ToInt32(split[j+1]));
                    list.Add(e);
                }
            }
            List<Edge> list2 = list.OrderBy(e => e.weight).ToList();
            Edge[] drzewo_rozpinajace = new Edge[n - 1];
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = i + 1;
            }
            num = 0;
            foreach (Edge edge in list2)
            {
                if (num == n - 1)
                    break;
                if (tab[edge.beg - 1] != tab[edge.end - 1])
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (tab[i] == tab[edge.beg - 1]) tab[i] = tab[edge.end - 1];
                    }
                    drzewo_rozpinajace[num] = edge;
                    num++;
                }
                else continue;
            }
            foreach (Edge krawedz in drzewo_rozpinajace)
            {
                out_file.Write("{0} {1} [{2}], ", krawedz.beg, krawedz.end, krawedz.weight);
            }
            in_file.Close();
            out_file.Close();
        }
    }
}
