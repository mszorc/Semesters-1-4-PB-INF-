using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Trojkat
    {
        Linia k, l, m;
        public Trojkat(Linia kk, Linia ll, Linia mm)
        {
            k = new Linia(kk);
            l = new Linia(ll);
            m = new Linia(mm);
        }
        public Trojkat(Trojkat klm)
        {
            k = new Linia(klm.k);
            l = new Linia(klm.l);
            m = new Linia(klm.m);
        }
        public void przesun(int a, int b)
        {
            k.przesun(a, b);
            l.przesun(a, b);
            m.przesun(a, b);
        }
        public override string ToString()
        {
            return String.Format("Trojkat {0}, {1}, {2}", k.ToString(), l.ToString(), m.ToString());
        }
    }
}
