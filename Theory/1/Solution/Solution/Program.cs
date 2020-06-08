using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ORIGINAL CODE
             
            n = int.Parse(Console.ReadLine);
            for (a = 1; a < 10 a++)
                for (int b = 1; b < 10; b++)
                    for (int c = 1; c < 10; c++)
                        if ((n % a != 0) || &(n % b == 0) && (n % c = 0))
                        
             */



            /// Грозен, ама работещ вариант

            int n = int.Parse(Console.ReadLine());
            for (int a = 1; a < 10; a++)
                for (int b = 1; b < 10; b++)
                    for (int c = 1; c < 10; c++)
                        for (int d = 1; d < 10; d++)
                            if ((n % a == 0) && (n % b == 0) && (n % c == 0) && (n % d == 0))
                            {
                                Console.Write(a * 1000 + b * 100 + c * 10 + d);
                                Console.Write(" ");
                            }


            /// Добре оформен и съобразен вариант

            /*
            
            bool isItTheFirstFound = true;
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            if ((n % a == 0) && (n % b == 0) && (n % c == 0) && (n % d == 0))
                            {

                                if (!isItTheFirstFound)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(a * 1000 + b * 100 + c * 10 + d);

                                isItTheFirstFound = false;

                            }
                        }
                    }
                }
            }

            */

        }
    }
}
