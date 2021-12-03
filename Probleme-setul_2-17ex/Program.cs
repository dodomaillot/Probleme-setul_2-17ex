using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_setul_2_17ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter 0 to stop the program
            int exercice = 1;
            while (exercice != 0)
            {
                Console.Write("Wich exercice do you want to do ? Exercice: ");
                exercice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (exercice)
                {
                    case 1:
                        Exercice_1();
                        break;

                    case 2:
                        Exercice_2();
                        break;
                }
                Console.WriteLine(); Console.WriteLine();
            }
        }
        private static void Exercice_1()
        {
            int n, nb, cont = 0;
            Console.WriteLine("Write a sequence of n numbers. How many numbers are even ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                nb = int.Parse(Console.ReadLine());
                if(nb % 2 == 0)
                    cont++;
            }
            Console.Write($"They are {cont} even number(s)");
        }

        private static void Exercice_2()
        {
            int n, nb, contneg = 0, contzero = 0, contpoz = 0;
            Console.WriteLine("Write a sequence of n numbers. How many numbers are negative, equal to zero and pozitive ?");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (nb < 0)
                    contneg++;
                else if (nb == 0)
                    contzero++;
                else
                    contpoz++;
            }
            Console.Write($"They are {contneg} negative number(s), {contzero} equal to zero and {contpoz} pozitive number(s)");
        }
    }
}
