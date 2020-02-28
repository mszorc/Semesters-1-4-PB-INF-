using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stos s1, s2;
            string s;
            s1 = new Stos();
            s1.Init(10);
            int i, x;
            for (i = 0; i < 3; i++)
            {
                s = Console.ReadLine();
                x = Convert.ToInt32(s);
                s1.Push(x);
            }
            s2 = new Stos();
            s2.Init(10);
            while (!s1.Empty()) 
            {
                x = s1.Top();
                s1.Pop();
                s2.Push(x);
            }
            while (!s2.Empty()) 
            {
                Console.WriteLine(s2.Top());
                s2.Pop();
            }
            Console.ReadKey();
        }
    }
}
