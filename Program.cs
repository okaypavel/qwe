
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace costamsprawdza
{
    class Tablica
    {
        public int[] tab = new int[5];

        public void Tablic()
        {
            int zapis;
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbe:" + " ");
                tab[i] = Convert.ToInt32(Console.ReadLine());
                if (tab[i] > -1 && tab[i] < 10)
                {
                    zapis = tab[i];
                }
                else
                {
                    i--;
                    Console.WriteLine("Podaj liczbe od 0 do 9 a nie..");
                }
            }
        }
        public string tysiwyz(long ttt)
        {
            string zwr = "";
            string napis = Convert.ToString(ttt);
            for (int i = 0; i < napis.Length; i++)
            {
                zwr += napis[i]+"*";
            }
            return zwr;
        }
        public void wypisywanie()
        {
            foreach (int wartosc in tab)
            {
                Console.WriteLine(switcz(wartosc));
            }
        }
        public string switcz(int a)
        {
            switch (a)
            {
                case 0:
                    return "zero";  

                case 1:
                    return "jeden";

                case 2:
                    return "dwa";

                case 3:
                    return "trzy";

                case 4:
                    return "cztery";

                case 5:
                    return "piec";

                case 6:
                    return "szesc";

                case 7:
                    return "siedem";

                case 8:
                    return "osiem";

                case 9:
                    return "dziewiec";
            }
            return "";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica tabl = new Tablica();
            Console.WriteLine(tabl.tysiwyz(123));
            //tabl.Tablic();
            //tabl.wypisywanie();
        }
    }
}

