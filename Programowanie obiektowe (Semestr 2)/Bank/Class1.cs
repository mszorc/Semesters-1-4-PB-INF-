using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bank
    {
        public List<Klient> klienci = new List<Klient>();
        public void dodajKlienta(Klient x)
        {
            klienci.Add(x);
        }
        public List<Klient> getKlienci()
        {
            return klienci;
        }
    }
    abstract class Klient
    {
        public List <Konto> konta = new List<Konto>();
        public void dodajKonto(Konto x)
        {
            konta.Add(x);
        }
        public List<Konto> getKonta()
        {
            return konta;
        }
    }
    class Konto
    {
        public string nr;
        public double saldo;
        public Konto(string numer)
        {
            nr = numer;
            saldo = 0;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public string getNr()
        {
            return nr;
        }
        public void wplac(double kwota)
        {
            saldo += kwota;
        }
        public void wyplac(double kwota)
        {
            saldo -= kwota;
        }
    }
    class Firma: Klient
    {
        public string nazwa;
        public string Krs;
        public Firma(string nazwa_, string krs_)
        {
            nazwa = nazwa_;
            Krs = krs_;
        }
        public override string ToString()
        {
            return nazwa +" "+ Krs;
        }
    }
    class DuzaFirma : Firma
    {
        public DuzaFirma(string nazwa_, string krs_): base(nazwa_,krs_)
        {

        }
        public override string ToString()
        {
            return nazwa + " " + Krs;
        }
    }
    class Osoba: Klient
    {
        public string imie, nazwisko, PESEL;
        public Osoba(string imie_, string nazwisko_, string PESEL_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            PESEL = PESEL_;
        }
        public override string ToString()
        {
            return imie + " " + nazwisko + " " + PESEL;
        }

    }
    class WaznaOsoba: Osoba
    {
        public WaznaOsoba(string imie_, string nazwisko_, string PESEL_): base(imie_, nazwisko_, PESEL_)
        {

        }
        public override string ToString()
        {
            return imie + " " + nazwisko + " " + PESEL;
        }

    }
}
