using System;

namespace Task01_second_method
{
    class Program
    {
        //5 olculu int tipde bir array yaradib ona random ededler menimsedin.
        //Daha sonra hemin arrayin elementlerini tersine duzun.
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int[] list = new int[5];

            for (int i = 0; i <5; i++)
            {
                list[i] = rndm.Next(0, 5);
            }

            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
}
