using System;

namespace Task02_second_method
{
    class Program
    {
        //5 olculu int tipde bir array yaradib ona random ededler menimsedin.
        //Daha sonra hemin arrayin elementlerinin cemini tapin.
        static void Main(string[] args)
        {
            int[] list = new int[5];
            Random rndm = new Random();
            int i = 0;
            int sum = 0;
            while (i < 5)
            {
                list[i] = rndm.Next(0, 5);
                i++;
            }
            
            Array.ForEach(list, delegate (int i) { sum += i; });
            Console.WriteLine(sum);
        }
    }
}
