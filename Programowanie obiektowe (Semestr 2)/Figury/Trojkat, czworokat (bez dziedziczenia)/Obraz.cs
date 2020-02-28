using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Obraz
    {
        private List<Trojkat> trojkaty = new List<Trojkat>();
        private List<Czworokat> czworokaty = new List<Czworokat>();
        public void dodajtrojkat(Trojkat x)
        {
            trojkaty.Add(x);
        }
        public void dodajczworokat(Czworokat x)
        {
            czworokaty.Add(x);
        }
        public Trojkat zwroc_trojkat(int x)
        {
            return trojkaty[x];
        }
        public Czworokat zwroc_czworokat(int x)
        {
            return czworokaty[x];
        }
    }
}
