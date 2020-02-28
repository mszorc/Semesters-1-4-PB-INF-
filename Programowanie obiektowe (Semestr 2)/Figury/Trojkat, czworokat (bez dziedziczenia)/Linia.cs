using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Linia
    {
        private Punkt a, b;
        public Linia()
        {
            a = new Punkt();
            b = new Punkt();
        }
        public Linia(Punkt aa, Punkt bb)
        {
            a = new Punkt(aa);
            b = new Punkt(bb);
        }
        public Linia(Linia kk)
        {
            a = new Punkt(kk.a);
            b = new Punkt(kk.b);
        }
        public void przesun(int aa, int bb)
        {
            a.przesun(aa,bb);
            b.przesun(aa,bb);
        }
        public override string ToString()
        {
            return a + "->" + b;
        }
    }
}
