using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Punkt
    {
        public int x, y;
        public Punkt()
        {
            x = 0;
            y = 0;
        }
        public Punkt(int xx, int yy)
        {
            x = xx;
            y = yy;
        }
        public Punkt(Punkt xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public void przesun(int xx, int yy)
        {
            x += xx;
            y += yy;
        }
        public int getx()
        {
            return x;
        }
        public int gety()
        {
            return y;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
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
            a.przesun(aa, bb);
            b.przesun(aa, bb);
        }
        public override string ToString()
        {
            return a + "->" + b;
        }
    }
    class Figura
    {
        public Punkt p1, p2, p3, p4;
        public Linia l1, l2, l3, l4;
        protected string kolor;
        public Figura(string kolor)
        {
            this.kolor = kolor;
        }
        public Figura()
        {
            kolor = "zółty";
        }
        public override string ToString()
        {
            return "Figura ma kolor: \n" + kolor;
        }
    }
    class Trojkat : Figura
    {
        public Trojkat(string kolor, Punkt p1, Punkt p2, Punkt p3): base(kolor)
        {
            l1 = new Linia(p1, p2);
            l2 = new Linia(p2, p3);
            l3 = new Linia(p3, p1);
        }
        public override String ToString()
        {
            return String.Format("Trojkat {0}, {1}, {2},", l1.ToString(), l2.ToString(), l3.ToString()) + kolor;
        }

    }
    class Czworokat : Figura
    {
        
        public Czworokat (string kolor, Punkt p1, Punkt p2, Punkt p3, Punkt p4): base(kolor)
        {
            l1 = new Linia(p1, p2);
            l2 = new Linia(p2, p3);
            l3 = new Linia(p3, p4);
            l4 = new Linia(p4, p1);
        }
        public override String ToString()
        {
            return String.Format("Czworokat {0}, {1}, {2}, {3},", l1.ToString(), l2.ToString(), l3.ToString(), l4.ToString()) + kolor;
        }
    }
    class Prostokat : Czworokat
    {
        public Prostokat(string kolor, Punkt x, Punkt y) : base(kolor, x, new Punkt(x.getx(), y.gety()), y, new Punkt(y.getx(), x.gety()))
        {

        }
        public override String ToString()
        {
            return String.Format("Prostokat {0}, {1}, {2}, {3},", l1.ToString(), l2.ToString(), l3.ToString(), l4.ToString()) + kolor;
        }
    }
    class Kwadrat : Prostokat
    {
        public Kwadrat(string kolor, Punkt x, int a): base(kolor,x,new Punkt(x.getx()+a,x.gety()+a))
        {

        }
        public override String ToString()
        {
            return String.Format("Kwadrat {0}, {1}, {2}, {3},", l1.ToString(), l2.ToString(), l3.ToString(), l4.ToString()) + kolor;
        }
    }
}
