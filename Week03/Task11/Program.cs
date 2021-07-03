using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //While-dan istifade ederek 1-den 100-e qeder olan ededler arasinda yerleshen cut ededlerin ozunu ve cemini console-a cixardin.
            int i = 1;
            while (i<=100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
                i++;
            }
        }
    }
}
