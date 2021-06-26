using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Client-dan iki eded daxil etmesini isteyin ve daxil edilen ededler arasindaki sade ededleri tapib ekrana cixardin.
             */

            Console.WriteLine("Zehmet olmasa iki eded daxil edin, Ilk kicik eded olsun:");
            int beginNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iKinci ve boyuk olan ededi daxil edin:");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{beginNumber} ve {endNumber} arasindaki sade edeler:");
            Console.WriteLine("_________________________________");

            for (int i = beginNumber; i < endNumber; i++)
            {
                if (i is 2 )
                {
                    Console.WriteLine(2);
                }
                if (i % 2 is not 0)
                {
                    int temp = 2;
                    for (int j = 2; j < i; j++)
                    {

                        if (i % j is not 0)
                        {
                            temp++;
                            if (temp==i)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            }


            /*
             * Console.WriteLine($"{beginNumber} ve {endNumber} arasindaki ededler:");
            if (beginNumber < endNumber)
            {

                while (beginNumber <= endNumber)
                {
                    int c = 0;
                    int j = 1;
                    while (j<= beginNumber)
                    {
                        if (beginNumber % j == 0)
                        {
                            c++;
                        }
                        j++;
                    }

                    if (c == 2)
                    {
                        Console.WriteLine(beginNumber);
                    }
                    beginNumber++;
                }
            }
            else
            {
                while (beginNumber >= endNumber)
                {
                    int c = 0;
                    int j = 1;
                    while (j <= beginNumber)
                    {
                        if (beginNumber % j == 0)
                        {
                            c++;
                        }
                        j++;
                    }

                    if (c == 2)
                    {
                        Console.WriteLine(beginNumber);
                    }
                    beginNumber--;
                }
            }
             */
        }
    }
}
