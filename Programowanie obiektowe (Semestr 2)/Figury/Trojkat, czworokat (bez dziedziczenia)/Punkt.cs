using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Punkt
    {
        private int x, y;
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
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
