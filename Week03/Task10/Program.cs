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

            Console.WriteLine("Zehmet olmasa iki eded daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{a} ve {b} arasindaki ededler:");
            if (a<b)
            {

                while (a <= b)
                {
                    int c = 0;
                    int j = 1;
                    while (j<=a)
                    {
                        if (a % j == 0)
                        {
                            c++;
                        }
                        j++;
                    }

                    if (c == 2)
                    {
                        Console.WriteLine(a);
                    }
                    a++;
                }
            }
            else
            {
                while (a >=b)
                {
                    int c = 0;
                    int j = 1;
                    while (j <= a)
                    {
                        if (a % j == 0)
                        {
                            c++;
                        }
                        j++;
                    }

                    if (c == 2)
                    {
                        Console.WriteLine(a);
                    }
                    a--;
                }
            }
        }
    }
}
