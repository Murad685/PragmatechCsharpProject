using System;

namespace Task01_first_method
{
    class Program
    {
        //5 olculu int tipde bir array yaradib ona random ededler menimsedin.
        //Daha sonra hemin arrayin elementlerini tersine duzun.
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int[] list = new int[5];
            int i = 0;
            while (i < 5)
            {
                list[i] = rndm.Next(0, 5);

                i++;
            }
            Console.WriteLine("Duz forma: "+ String.Join(',', list));

            Array.Reverse(list);

            Console.WriteLine("Ters forma: " + String.Join(',', list));
        }
    }
}
