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
            int beginNumber = 2;
            int endNumber = 100;
            for (int i = beginNumber; i < endNumber; i++)
            {
                if (i is 2)
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
                            if (temp == i)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            }
        }
    }
}
