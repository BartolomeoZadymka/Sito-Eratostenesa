using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitoEra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sito Eratostenesa");
            Console.WriteLine("Liczby pierwsze od 2 do n (max. {0}): ", N);
            if (Generuj())
            {
                Przesiewaj();
                for (int k = 0; k < n; k++)
                    Console.Write("{0,7} ", x[k]);
                Console.WriteLine();
            }
        }

        static bool Generuj()           // Utworzenie listy liczb 2-n
        {
            Console.Write("n = ");
            try
            {
                n = int.Parse(Console.ReadLine().Trim());
                if (n < 2 || n > N)
                    throw new Exception("Nieprawidłowy zakres n.");
                x = new int[--n];
                for (int k = 0; k < n; k++)
                    x[k] = k + 2;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        static void Przesiewaj()        // Sito Eratostenesa
        {
            for (int p = 0; p < n; p++)
                for (int q = p + 1; q < n;)
                    if (x[q] % x[p] == 0)
                    {
                        n--;
                        for (int k = q; k < n; k++)
                            x[k] = x[k + 1];
                    }
                    else
                        q++;
        }

        static int[] x = null;          // Tablica (lista) liczb pierwszych
        static int n;                   // Faktyczny zakres i rozmiar listy
        static readonly int N = 25000;  // Maksymalny zakres
    }
}
