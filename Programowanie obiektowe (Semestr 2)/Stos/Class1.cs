using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Stos
    {
        int[] t;
        int pozycja;
        public void Init(int rozmiar)
        {
            t = new int[rozmiar];
            pozycja = -1;
        }
        public void Push(int x)
        {
            t[++pozycja] = x;
        }
        public void Pop()
        {
            pozycja--;
        }
        public int Top()
        {
            return t[pozycja];
        }
        public bool Empty()
        {
            return pozycja == -1;
        }
        public bool Full()
        {
            return pozycja == t.Length - 1;
        }
        public void Destroy()
        {

        }
    }
}
