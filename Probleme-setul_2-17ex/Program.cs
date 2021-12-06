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

                    case 5:
                        Exercice_5();
                        break;

                    case 6:
                        Exercice_6();
                        break;

                    case 7:
                        Exercice_7();
                        break;

                    case 8:
                        Exercice_8();
                        break;

                    case 9:
                        Exercice_9();
                        break;

                    case 10:
                        Exercice_10();
                        break;

                    case 11:
                        Exercice_11();
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

        private static void Exercice_5()
        {
            int n, nb, tot = 0;
            
            Console.WriteLine("Type a sequence of n numbers. Check how many numbers in the sequence are equal to theres positions");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n;i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (nb == i)
                    tot++;
            }
            
            if (tot == 0)
                Console.Write("There are no numbers equal to there position");
            else
                Console.Write("there is/are " + tot + " numbers equals to there position");
        }

        private static void Exercice_6()
        {
            int n, nb, prev;
            bool ascending = true;
            
            Console.WriteLine("Type a sequence of n numbers. Check if the numbers are in an ascending order");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            nb = int.Parse(Console.ReadLine());
            prev = nb; 
            for (int i=0;i<n-1;i++)
            {
                nb = int.Parse(Console.ReadLine());
                if(nb < prev)
                {
                    ascending = false;
                }
                prev = nb;
            }
            
            if (ascending == false)
                Console.Write("Numbers are not in an ascending order");
            else
                Console.Write("Numbers are in an ascending order");
        }

        private static void Exercice_7()
        {
            int n, nb, min, max;
            
            Console.WriteLine("Type a sequence of n numbers. Display the bigger and the smaller value of the sequence");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            
            nb = int.Parse(Console.ReadLine());
            min = max = nb;
            for(int i = 0; i<n-1;i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (nb < min)
                    min = nb;
                if (nb > max)
                    max = nb;
            }

            Console.Write($"The bigger number is: {max} and the smaller is: {min}");
        }

        private static void Exercice_8()
        {
            int n, Fn_1 = 1, Fn_2 = 0, Fn = 1;
            
            Console.WriteLine("Display the n-th number of the Fibonacci sequence");
            Console.Write("F_n = ? ; n = "); n = int.Parse(Console.ReadLine());

            if (n == 0)
                Console.Write(Fn_2);
            else if (n == 1)
                Console.Write(Fn_1);
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    Fn = Fn_1 + Fn_2;
                    Fn_2 = Fn_1;
                    Fn_1 = Fn;
                }

                Console.Write(Fn);
            }
        }

        private static void Exercice_9()
        {
            int n, nb, prev;
            bool neg = false, poz = false;

            Console.WriteLine("Check if a sequence of n numbers is monotone");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            
            nb = int.Parse(Console.ReadLine());
            prev = nb;
            for(int i = 0; i < n-1; i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (nb > prev)
                    poz = true;
                else if (nb < prev)
                    neg = true;

                prev = nb;
            }

            if (poz == true && neg == false)
                Console.Write("The sequence is monotonic increasing");
            else if (poz == false && neg == true)
                Console.Write("The sequence is monotonic decreasing");
            else
                Console.Write("The sequence has no monotone");
        }

        private static void Exercice_10()
        {
            int n, nb, cons = 1, prev, maxcons = 1;
            
            Console.WriteLine("Type a sequence of n numbers. What is the maximum number of consecutive equal numbers");
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            nb = int.Parse(Console.ReadLine());
            prev = nb;
                        
            for(int i = 0; i < n-1; i++)
            {
                nb = int.Parse(Console.ReadLine());
                if (nb == prev)
                    cons++;
                else
                {
                    maxcons = cons;
                    cons = 1;
                }
                prev = nb;
            }
            if (cons > maxcons)
                maxcons = cons;
            Console.Write(maxcons);
        }

        private static void Exercice_11()
        {
            int n, nb, Ex, inv = 0, p = 1;
            float sum = 0F;

            Console.WriteLine("Type a sequence of n numbers. Display the sum of the inverse of the numbers");
            Console.WriteLine("1-) ex: 12 inverse(mirror) => 21 or 2-) 12 inverse => 1/12");
            Console.Write("1 or 2 ? "); Ex = int.Parse(Console.ReadLine());
            Console.Write("n = "); n = int.Parse(Console.ReadLine());

            if(Ex == 2)
                for (int i = 0; i < n; ++i)
                {
                    nb = int.Parse(Console.ReadLine());
                    sum += 1 / (float)nb;
                }
            else if(Ex == 1)
            {
                for (int i = 0; i < n; ++i)
                {
                    nb = int.Parse(Console.ReadLine());
                    while(nb != 0)
                    {
                        inv = inv * p + nb % 10;
                        p *= 10;
                        nb /= 10;
                    }
                    sum += (float)inv;
                    inv = 0; p = 1;
                }
            }
            Console.Write(Math.Round(sum, 2));
        }

        
    }
}
