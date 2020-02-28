using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
    class Figura
    {
        public Punkt s;
        public int r;
        public double pole;
        public double obwod;
        public Figura(Punkt srodek, int promien)
        {
            s = srodek;
            r = promien;
        }
        public virtual void Pole()
        {

        }
        public virtual void Obwod()
        {

        }
        public virtual void Przesun(int x, int y)
        {
            s.x += x;
            s.y += y;
        }
        public virtual void Skaluj(int x)
        {
            r *= x;
        }
        public double zwrocObwod()
        {
            return obwod;
        }
        public double zwrocPole()
        {
            return pole;
        }
    }
    class Kolo : Figura
    {
        public Kolo(Punkt s, int r) : base(s,r)
        {

        }
        public override void Pole()
        {
            base.Pole();
            pole = 0.0;
            pole += 3.14 * r * r;
        }
        public override void Obwod()
        {
            base.Obwod();
            obwod = 0.0;
            obwod += 2 * 3.14 * r;
        }
        public override void Przesun(int x, int y)
        {
            base.Przesun(x, y);
        }
        public override void Skaluj(int x)
        {
            base.Skaluj(x);
        }
    }
    class Kwadrat : Figura
    {
        public Kwadrat(Punkt s, int r) : base(s,r)
        {

        }
        public override void Pole()
        {
            base.Pole();
            pole = 0.0;
            pole += r * r;
        }
        public override void Obwod()
        {
            base.Obwod();
            obwod = 0.0;
            obwod += 4 * r;
        }
        public override void Przesun(int x, int y)
        {
            base.Przesun(x, y);
        }
        public override void Skaluj(int x)
        {
            base.Skaluj(x);
        }

    }
}
