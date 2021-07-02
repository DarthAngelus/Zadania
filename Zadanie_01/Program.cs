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

            Console.WriteLine("KALKULATOR");
            Console.Write("Pierwsza liczba:\t");
            string s = Get();
            float a = Convert.ToSingle(s);
            //s = s.Replace(".", ",");
            Console.Write("Operator (+,-,*,/):\t");
            char oper = Console.ReadKey().KeyChar;
            Console.Write("\nDruga liczba:\t");
            s = Get();

            //Console.WriteLine(Convert.ToSingle(s));
            float b = Convert.ToSingle(s);

            Console.WriteLine(a + " | " + b);

            //string s = Get();
            Operator(oper, a, b);

            Console.ReadKey();
        }
        static string Get()
        {
            return Console.ReadLine().Replace(".",",");
        }
        static void Operator(char znak, float a, float b)
        {
            //Console.WriteLine("Operator (+,-,*,/): ");
            //char znak = Convert.ToChar(Console.ReadKey());
            //char znak = Console.ReadKey().KeyChar;
           // float wynik;
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
                    Console.WriteLine();
                    break;
            }
        }
        private static void Pisz(string v)
        {
            //string s;
            Console.WriteLine("Wynik działania:\t" + v);
        }

        private static float Dodaj(float a, float b)
        {
            float wynik = a + b;
            return wynik;
        }
        private static float Odejmij(float a, float b)
        {
            float wynik = a - b;
            return wynik;
        }
        private static float Pomnoz(float a, float b)
        {
            float wynik = a * b;
            return wynik;
        }
    }
}
