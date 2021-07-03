using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================");
            Console.WriteLine(">> KALKULATOR <<");
            Console.WriteLine("================\n");
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
        /// Pobieranie zmiennych od użytkownika i wywołanie metody Operator
        /// </summary>
        static void Glowna()
        { 
            Console.Write("Pierwsza liczba:\t");
            string s = Get();
            float a = Convert.ToSingle(s);
            
            Console.Write("Operator (+,-,*,/):\t");
            char oper = Console.ReadKey().KeyChar;
            
            Console.Write("\nI druga liczba:\t\t");
            s = Get();
            float b = Convert.ToSingle(s);

            Console.WriteLine("\tOperacja: " + a + " " + oper + " " + b);

            Operator(oper, a, b);
        }
        /// <summary>
        /// zmiana ewentualnej "." na "," w stringu będącym w założeniu liczbą,
        /// aby nie było problemu przy konwersji do float w przypadku podania w innym formacie
        /// </summary>
        /// <returns></returns>
        static string Get()
        {
            return Console.ReadLine().Replace(".",",");
        }
        /// <summary>
        /// Wybór odpowiedniego działana matem. w zależności od pobranej oper z metody Glowna
        /// </summary>
        /// <param name="znak"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Operator(char znak, float a, float b)
        {
            //char znak = Convert.ToChar(Console.ReadKey());
            //char znak = Console.ReadKey().KeyChar;
            switch (znak)
            {
                case (char)'+':
                    Pisz(Dodaj(a, b).ToString());
                    break;
                case (char)'-':
                    Pisz(Odejmij(a, b).ToString());
                    break;
                case (char)'*':
                    Pisz(Pomnoz(a, b).ToString());
                    break;
                case (char)'/':
                    if (b != 0.0)
                        Pisz(Podziel(a, b).ToString());
                    else
                        Console.WriteLine("Pamiętaj ty jeden, nie dziel przez zero!");
                    break;
                default:
                    Console.WriteLine("Nieobsługiwany operator");
                    break;
            }
        }
        /// <summary>
        /// Wyświetla tekst + stringa
        /// </summary>
        /// <param name="v"></param>
        private static void Pisz(string v)
        {
            //string s;
            Console.WriteLine("Wynik działania:\t" + v);
        }
        /// <summary>
        /// Operacja dodawania
        /// </summary>
        /// <returns>obliczony wynik działania</returns>
        private static float Dodaj(float a, float b)
        {
            float wynik = a + b;
            return wynik;
        }
        /// <summary>
        /// Operacja odejmowania
        /// </summary>
        /// <returns>obliczony wynik działania</returns>
        private static float Odejmij(float a, float b)
        {
            float wynik = a - b;
            return wynik;
        }
        /// <summary>
        /// Operacja mnożenia
        /// </summary>
        /// <returns>obliczony wynik działania</returns>
        private static float Pomnoz(float a, float b)
        {
            float wynik = a * b;
            return wynik;
        }
        /// <summary>
        /// Operacja dzielenia
        /// </summary>
        /// <returns>obliczony wynik działania</returns>
        private static float Podziel(float a, float b)
        {
            float wynik = a / b;
            return wynik;
        }
    }
}
