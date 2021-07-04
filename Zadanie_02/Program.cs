using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOTEL TRANSYLVANIA");
            Console.Write("Podaj ile chcesz spędzić nocy: ");
            uint ileNocy = Convert.ToUInt32(Console.ReadLine());

            if (ileNocy == 0)
            {
                Console.WriteLine("\nNo to do zobaczenia następnym razem.");
            }
            else
            {
                Console.Write("Podaj swój wiek: ");
                uint ileLat = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("\n\tCena pobytu: " + PrzydzialGrupy(ileNocy, ileLat) + " zł.");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Sprawdza wiek, realizuje odpowiednią instrukcję / metodę i zwraca wynik
        /// </summary>
        /// <returns>kosztCalkowity</returns> - zwraca wyliczoną ostateczną wartość
        private static uint PrzydzialGrupy(uint ileNocy, uint ileLat)
        {
            uint kosztCalkowity;
            double mnoznik = 1.0;
            if (ileLat < 18)
            {
                uint cenaDlaNieletniego = 100;
                kosztCalkowity = ileNocy * cenaDlaNieletniego;
                return kosztCalkowity;
            }
            else if (ileLat < 65)
            {
                kosztCalkowity = NaliczOplate(ileNocy, mnoznik);
                return kosztCalkowity;
            }
            else
            {
                mnoznik = 0.9;
                kosztCalkowity = NaliczOplate(ileNocy, mnoznik);
                return kosztCalkowity;
            }
        }
        /// <summary>
        /// Naliczanie opłaty dla pełnoletnich
        /// </summary>
        /// <param name="noce"></param> - ilość noclegów, pobrana jeszcze w metodzie Main
        /// <param name="rabat"></param> - wartość typu double, odpowiednio 0.9 dla emerytow i 1.0 dla reszty
        /// <returns>(uint)(stawka1 * noce * rabat)</returns> - zwraca wyliczony iloczyn
        private static uint NaliczOplate(uint noce, double rabat)
        {
            uint stawka1 = 150;
            uint stawka2 = 180;
            uint stawka3 = 200;
            uint przedzial1 = 5;
            uint przedzial2 = 2;
            //uint przedzial3 = 1;
            if (noce >= przedzial1)
                return (uint)(stawka1 * noce * rabat);
            else if (noce >= przedzial2)
                return (uint)(stawka2 * noce * rabat);
            else
                return (uint)(stawka3 * noce * rabat);
        }
    }
}
