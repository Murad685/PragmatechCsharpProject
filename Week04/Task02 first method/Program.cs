using System;

namespace Task02_first_method
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
            int cem = 0;
            while (i<5)
            {
                list[i] = rndm.Next(0, 5);
                i++;
            }
            foreach (var item in list)
            {

                cem += item;
                
            }
            Console.WriteLine("Listin elementleri ve onlarin cemi: " + String.Join('+', list)+"="+ cem);
        }
    }
}
