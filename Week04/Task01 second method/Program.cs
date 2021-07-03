using System;

namespace Task01_second_method
{
    class Program
    {
        //5 olculu int tipde bir array yaradib ona random ededler menimsedin.
        //Daha sonra hemin arrayin elementlerini tersine duzun.
        static void Main(string[] args)
        {
            int[] array = new int[5] { 3, 1, 4, 5, 2 };

            for (int i = 4; i >-1; i--)
            {
                Console.WriteLine( array[i]);
            }
            
        }
    }
}
