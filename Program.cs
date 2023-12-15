/*Pentru a rezolva problemele din acest test funcțiile joacă un rol important în a ușura munca și a conferi claritate codului.

Stadiul 2 din 2

Problema de rezolvat:

Într-o anumită țară, numerele de pe plăcuțele de înmatriculare a mașinilor se formează folosind M cifre, dintre cifrele de la 1 la 9, și N litere, 
dintre cele 26 de litere ale alfabetului englez.

Câte numere de înmatriculare se pot forma dacă fiecare cifră sau literă poate apărea într-un număr doar o singură dată?

Exemplu:

Pentru datele de intrare:

2
3
La consolă se va afișa:

1123200*/

using System;

namespace NumereInmatriculare
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            long result = CalculeazaNumereInmatriculare(M, N);
            Console.WriteLine(result);
        }

        static long CalculeazaNumereInmatriculare(int M, int N)
        {
            long result = 1;


            for (int i = 9; i > 9 - M; i--)
            {
                result *= i;
            }

            for (int i = 26; i > 26 - N; i--)
            {
                result *= i;
            }

                                    return result;
        }
    }
}


