using System;
using System.IO;

namespace BinarySearchTree
{
    class Wezel
    {
        public string slowo;
        public Wezel tlumaczenie;
        public Wezel lewo;
        public Wezel prawo;
        public Wezel(string slowo_)
        {
            slowo = slowo_;
            tlumaczenie = null;
            lewo = null;
            prawo = null;
        }
        public Wezel()
        {
            slowo = null;
            tlumaczenie = null;
            lewo = null;
            prawo = null;
        }
    }
    class Drzewo
    {
        private string slowo_pom;
        private void output(StreamWriter out_file, Wezel korzen)
        {
            out_file.WriteLine(korzen.slowo);
        }
        public Wezel insert(Wezel korzen, Wezel korzen_pom, StreamWriter out_file1)
        {
            if (korzen == null)
            {
                korzen = new Wezel();
                korzen.slowo = korzen_pom.slowo;
                korzen.tlumaczenie = korzen_pom.tlumaczenie;
                output(out_file1, korzen);
            }
            else if (korzen.slowo == korzen_pom.slowo)
            {
                //Console.WriteLine("Słowo istnieje już w słowniku");
            }
            else if (string.Compare(korzen_pom.slowo, korzen.slowo) == -1)
            {
                korzen.lewo = insert(korzen.lewo, korzen_pom, out_file1);
            }
            else if (string.Compare(korzen_pom.slowo, korzen.slowo) == 1)
            {
                korzen.prawo = insert(korzen.prawo, korzen_pom, out_file1);
            }
            return korzen;
        }
        public Wezel insert1(Wezel korzen, Wezel korzen_pom)
        {
            if (korzen == null)
            {
                korzen = new Wezel();
                korzen.slowo = korzen_pom.slowo;
                korzen.tlumaczenie = korzen_pom.tlumaczenie;
            }
            else if (korzen.slowo == korzen_pom.slowo)
            {
                Console.WriteLine("Słowo istnieje już w słowniku");
            }
            else if (string.Compare(korzen_pom.slowo, korzen.slowo) == -1)
            {
                korzen.lewo = insert(korzen.lewo, korzen_pom);
            }
            else if (string.Compare(korzen_pom.slowo, korzen.slowo) == 1)
            {
                korzen.prawo = insert(korzen.prawo, korzen_pom);
            }
            return korzen;
        }
        private Wezel insert(Wezel korzen, Wezel korzen_pom)
        {
            if (korzen == null)
            {
                korzen = new Wezel();
                korzen.slowo = korzen_pom.slowo;
                korzen.tlumaczenie = korzen_pom.tlumaczenie;
            }
            else if (korzen.slowo == korzen_pom.slowo)
            {
                Console.WriteLine("Słowo istnieje już w słowniku");
                return null;
            }
            else if (string.Compare(korzen_pom.slowo, korzen.slowo) == -1)
            {
                korzen.lewo = insert(korzen.lewo, korzen_pom);
            }
            else if (string.Compare(korzen_pom.slowo, korzen.slowo) == 1)
            {
                korzen.prawo = insert(korzen.prawo, korzen_pom);
            }
            return korzen;
        }
        public Wezel insert_translation(Wezel korzen_ang, Wezel korzen_pl)
        {
            bool a = true;
            Wezel n = new Wezel();
            string x = "";
            if (korzen_ang == null) return null;
            if (korzen_ang.tlumaczenie == null)
            {
                while (a == true)
                {
                    Console.Write("Podaj tłumaczenie słowa '{0}': ", korzen_ang.slowo);
                    x = Console.ReadLine();
                    a = find(korzen_pl, x);
                    if (a == false) 
                    {
                        n.slowo = x;
                        n.tlumaczenie = korzen_ang;
                        korzen_ang.tlumaczenie = n;
                        korzen_pl = insert(korzen_pl, n);
                    }
                }
            }
            insert_translation(korzen_ang.lewo, korzen_pl);
            insert_translation(korzen_ang.prawo, korzen_pl);
            return korzen_pl;
        }
        public bool find(Wezel korzen, string slowo)
        {
            int a = 0;
            if (korzen == null)
            {
                return false;
            }
            while (korzen.slowo != slowo)
            {
                if (korzen == null)
                {
                    a = 1;
                    break;
                }
                else if (string.Compare(slowo, korzen.slowo) == 0)
                {
                    a = 0;
                    break;
                }
                else if (string.Compare(slowo, korzen.slowo) == -1)
                {
                    if (korzen.lewo == null)
                    {
                        a = 1;
                        break;
                    } 
                    korzen = korzen.lewo;
                }
                else if (string.Compare(slowo, korzen.slowo) == 1)
                {
                    if (korzen.prawo == null)
                    {
                        a = 1;
                        break;
                    }
                    korzen = korzen.prawo;
                }
            }
            if (a == 0) return true;
            else return false;
        }
        public void display(Wezel korzen, StreamWriter out_file)
        {
            if (korzen == null)
            {
                return;
            }
            out_file.WriteLine("{0} {1}", korzen.slowo, korzen.tlumaczenie.slowo);
            display(korzen.lewo, out_file);
            display(korzen.prawo, out_file);
        }
        public string translate(Wezel korzen, string slowo)
        {
            if (korzen == null)
            {
                slowo_pom = "Brak słowa w słowniku";
            }
            else if (string.Compare(slowo, korzen.slowo) == 0)
            {
                slowo_pom = korzen.tlumaczenie.slowo;
            }
            else if (string.Compare(slowo, korzen.slowo) == -1)
            {
                translate(korzen.lewo, slowo);
            }
            else if (string.Compare(slowo, korzen.slowo) == 1)
            {
                translate(korzen.prawo, slowo);
            }
            return slowo_pom;
        }
        private Wezel delete(Wezel korzen, string slowo)
        {
            if (korzen == null)
            {
                return korzen;
            }
            if (string.Compare(slowo, korzen.slowo) == 1)
            {
                korzen.prawo = delete(korzen.prawo, slowo);
            }
            else if (string.Compare(slowo, korzen.slowo) == -1)
            {
                korzen.lewo = delete(korzen.lewo, slowo);
            }
            else
            {
                if (korzen.lewo == null)
                {
                    return korzen.prawo;
                }
                else if (korzen.prawo == null)
                {
                    return korzen.lewo;
                }
                korzen.slowo = minValue(korzen.prawo);
                korzen.tlumaczenie = minValue1(korzen.prawo);
                korzen.prawo = delete(korzen.prawo, korzen.slowo);
            }
            return korzen;
        }
        private Wezel delete_translation(string key, Wezel rootPL, Wezel rootEN)
        {
            if (rootEN == null) return null;
            if (rootEN.slowo == key)
            {
                rootPL = delete(rootPL, rootEN.tlumaczenie.slowo);
            }
            else
            {
                delete_translation(key, rootPL, rootEN.lewo);
                delete_translation(key, rootPL, rootEN.prawo);
            }
            return rootPL;
        }
        public void remove(Wezel korzen, Wezel korzen_pl, string slowo)
        {
            korzen_pl = delete_translation(slowo, korzen_pl, korzen);
            korzen = delete(korzen, slowo);
        }
        private string minValue(Wezel korzen)
        {
            string mins = korzen.slowo;
            while (korzen.lewo != null)
            {
                mins = korzen.lewo.slowo;
                korzen = korzen.lewo;
            }
            return mins;
        }
        private Wezel minValue1(Wezel korzen)
        {
            string mins = korzen.slowo;
            while (korzen.lewo != null)
            {
                mins = korzen.lewo.slowo;
                korzen = korzen.lewo;
            }
            return korzen.tlumaczenie;
        }
    }
    class BST
    {
        static void Main(string[] args)
        {
            StreamReader in_file = new StreamReader("In0402.txt");
            StreamWriter out_file1 = new StreamWriter("OutA0402.txt");  
            Wezel korzen = null;
            Wezel korzen_pom = null;
            Drzewo bst = new Drzewo();
            Wezel korzen_pl = null;
            int caseSwitch = 30;
            bool txt = false;
            while (caseSwitch != 0)
            {
                Console.WriteLine("1 - dodaj do słownika wyrazy z pliku In0402.txt");
                Console.WriteLine("2 - dodaj do słownika własny wyraz");
                Console.WriteLine("3 - dodaj tłumaczenia słów");
                Console.WriteLine("4 - usuń słowo angielskie ze słownika");
                Console.WriteLine("5 - usuń słowo polskie ze słownika");
                Console.WriteLine("6 - dodaj drzewo do pliku wynikowego OutB0402.txt");
                Console.WriteLine("7 - przetłumacz slowo (ang-pl)");
                Console.WriteLine("8 - przetłumacz słowo (pl-ang)");
                Console.WriteLine("0 - exit");
                caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        string x = in_file.ReadLine();
                        if (txt == false)
                        {
                            string[] split = x.Split(new Char[] { ' ' });
                            for (int i = 0; i < split.Length; i++)
                            {
                                korzen_pom = new Wezel(split[i]);
                                korzen = bst.insert(korzen, korzen_pom, out_file1);
                            }
                            txt = true;
                            Console.WriteLine("Słowa zostały dodane do drzewa");
                        }
                        else Console.WriteLine("Plik był już wczytany");
                        Console.ReadKey();
                        break;
                    case 2:                     
                        Console.Write("Podaj wyraz angielski: ");
                        x = Console.ReadLine();
                        korzen_pom = new Wezel(x);
                        korzen = bst.insert1(korzen, korzen_pom);
                        Console.ReadKey();
                        break;
                    case 3:
                        korzen_pl = bst.insert_translation(korzen, korzen_pl);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Podaj wyraz angielski: ");
                        x = Console.ReadLine();
                        bst.remove(korzen, korzen_pl, x);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Podaj wyraz polski: ");
                        x = Console.ReadLine();
                        bst.remove(korzen_pl, korzen, x);
                        Console.ReadKey();
                        break;
                    case 6:
                        StreamWriter out_file2 = new StreamWriter("OutB0402.txt");
                        bst.display(korzen, out_file2);
                        out_file2.Close();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Podaj słowo w języku angielskim: ");
                        x = Console.ReadLine();
                        Console.WriteLine(bst.translate(korzen, x));
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Podaj słowo w języku polskim: ");
                        x = Console.ReadLine();
                        Console.WriteLine(bst.translate(korzen_pl, x));
                        Console.ReadKey();
                        break;
                    case 0:
                        caseSwitch = 0;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
            out_file1.Close();          
        }
    }
}