using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sprawdzanie czy liczba pierwsza.\n");
            do
                Glowna();
            while (Koniec());
            Console.ReadKey();
        }
        /// <summary>
        /// Metoda do zakończenia aplikacji jeśli wciśnięty ostanie znak "n"
        /// </summary>
        /// <returns>Podanie "n" zwraca false by wyjść z pętli w metodzie Main </returns>
        private static bool Koniec()
        {
            Console.Write("\nCzy chcesz kontynuować? [T/N]: ");
            char end = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();
            if (end == 'n' || end == 'N')
            {
                Console.WriteLine("==============");
                Console.WriteLine("|   Koniec   |");
                Console.WriteLine("==============");
                return false;
            }
            else return true;
        }
        /// <summary>
        /// Pobieranie zmiennych od użytkownika i wywołanie metody Sprawdz
        /// </summary>
        static void Glowna()
        {
            Console.Write("Podaj liczbę całkowitą większą od 1: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p < 2)
                Console.WriteLine(p + " nie jest większa od 1.");
            else if (Sprawdz(p) == true)
                Console.WriteLine("Liczba " + p + " jest liczbą pierwszą." );
            else
                Console.WriteLine("Liczba " + p + " nie jest liczbą pierwszą.");
        }
        /// <summary>
        /// Sprawdza czy liczba jest pierwsza
        /// </summary>
        /// <param name="p"></param>
        /// <returns>pierwsza</returns>domyślnie jest true, jeśli warunek 
        /// znajdzie resztę z dzielenia to zwróci false i wyjdzie z pętli
        private static bool Sprawdz(int p)
        {
            bool pierwsza = true;
            double pierwiastek = Math.Floor(Math.Sqrt(p));
            for (int i = 2; i <= pierwiastek; i++)
            {
                if ((p % i) == 0)
                {
                    pierwsza = false;
                    break;
                }
            }
            return pierwsza;
        }
    }
}
