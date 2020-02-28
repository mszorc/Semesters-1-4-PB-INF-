using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    namespace kartoteka
    {
        public class Osoba
        {
            private string imie;
            private string nazwisko;
            public Osoba(string imie_, string nazwisko_)
            {
                imie = imie_;
                nazwisko = nazwisko_;
            }
            public string getImie()
            {
                return imie;
            }
            public string getNazwisko()
            {
                return nazwisko;
            }
            public void setImie(string imie_)
            {
                imie = imie_;
            }
            public void setNazwisko(string nazwisko_)
            {
                nazwisko = nazwisko_;
            }
        }
    }
    namespace mockup
    {
        public class Kartoteka
        {
            public void dodaj(kartoteka.Osoba osoba)
            {

            }
            public void usun(kartoteka.Osoba osoba)
            {

            }
            public int rozmiar()
            {
                return 1;
            }
            public bool czyZawiera(kartoteka.Osoba osoba)
            {
                return true;
            }
            public kartoteka.Osoba pobierz(int x)
            {
                return new kartoteka.Osoba("Gall", "Anonim");
            }
        }
    }
    namespace impl
    {
        public class Kartoteka
        {
            private List<kartoteka.Osoba> kartoteka = new List<kartoteka.Osoba>();
            public void dodaj(kartoteka.Osoba osoba)
            {
                kartoteka.Add(new kartoteka.Osoba(osoba.getImie(),osoba.getNazwisko()));
            }
            public void usun(kartoteka.Osoba osoba)
            {
                int i = 0;
                for (i=0;i<kartoteka.Count();i++)
                {
                    if (kartoteka[i].getImie()==osoba.getImie() && kartoteka[i].getNazwisko()==osoba.getNazwisko())
                    {
                        kartoteka.RemoveAt(i);
                    }
                }
            }
            public int rozmiar()
            {
                return kartoteka.Count();
            }
            public bool czyZawiera(kartoteka.Osoba osoba)
            {
                int i = 0;
                for (i=0;i<kartoteka.Count();i++)
                {
                    if (kartoteka[i].getImie()==osoba.getImie() && kartoteka[i].getNazwisko()==osoba.getNazwisko())
                    {
                        return true;
                    }
                }
                return false;
            }
            public kartoteka.Osoba pobierz(int x)
            {
                return kartoteka[x];
            }
        }
    }
}
