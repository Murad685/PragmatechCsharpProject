using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2-den 100-e qeder ededler arasinda sade ededleri(1e ve ozune bolunen) tapib ekrana cixardin.
             */
            int a = 2;
            int b = 100;
            while (a <= b)
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
                a++;
            }
        }
    }
}
