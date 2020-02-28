using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Czworokat
    {
        Linia k, l, m, n;
        public Czworokat(Linia kk, Linia ll, Linia mm, Linia nn)
        {
            k = new Linia(kk);
            l = new Linia(ll);
            m = new Linia(mm);
            n = new Linia(nn);
        }
        public Czworokat(Czworokat klmn)
        {
            k = new Linia(klmn.k);
            l = new Linia(klmn.l);
            m = new Linia(klmn.m);
            n = new Linia(klmn.n);
        }
        public void przesun(int a, int b)
        {
            k.przesun(a, b);
            l.przesun(a, b);
            m.przesun(a, b);
            n.przesun(a, b);
        }
        public override string ToString()
        {
            return String.Format("Czworokat {0}, {1}, {2}, {3}", k.ToString(), l.ToString(), m.ToString(), n.ToString());
        }

    }
}
