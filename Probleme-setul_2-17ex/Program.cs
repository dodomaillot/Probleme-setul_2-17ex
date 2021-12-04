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
                Console.Write("Wich problem do you want to try ? Problem #: ");
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

                    case 3:
                        Exercice_3();
                        break;

                    case 4:
                        Exercice_4();
                        break;
                }
                Console.WriteLine(); Console.WriteLine();
            }
        }
        private static void Exercice_1()
        {
            int n, nb, cont = 0;
            Console.WriteLine("Type a sequence of n numbers. How many numbers are even ?");
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
            Console.WriteLine("Type a sequence of n numbers. How many numbers are negative, equal to zero and pozitive ?");
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
        
        private static void Exercice_3()
        {
            int n, sum = 1, prod = 1;
            Console.WriteLine("Diplay the sum and the product of the numbers from 1 to n.");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                sum += i;
                prod *= i;
            }
            Console.Write($"The sum is equal to {sum} and the product is equal to {prod}");
        }

        private static void Exercice_4()
        {
            int n, nb, a; string lol = null;
            Console.WriteLine("Type a sequence of n numbers and a number a. The program will diplay the position(s) of the numbers a in the sequence   (Diplay -1 if there is not a number a).");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            Console.Write("a = "); a = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (a == nb)
                {
                    lol += i.ToString() + "; ";
                }
            }
            if (lol == null)
                Console.Write("-1");
            else
                Console.Write(lol);
        }
    }
}
