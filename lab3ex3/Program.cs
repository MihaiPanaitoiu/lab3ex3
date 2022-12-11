using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 3
             Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul
             */

            //patrat perfect = un număr întreg care este pătratul unui alt număr. Rădăcina pătrată a unui pătrat perfect este un număr întreg.

            static bool isPerfectSquare(int n)
            {
                //daca restul impartirii radacinii patrate a lui n la 1 este 0, este patrat perfect
                if (Math.Sqrt(n) % 1 == 0)
                {
                    return true;
                }
                return false;
            }

            Console.WriteLine("Introduceti numarul: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numarul {n} {(isPerfectSquare(n) ? "este" : "nu este")} patrat perfect");
        }
    }
}
