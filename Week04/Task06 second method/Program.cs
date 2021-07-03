using System;
using System.Linq;
namespace Task06_second_method
{
    class Program
    {
        //Arrayin minimum elementini tapin.
        static void Main(string[] args)
        {
            int[] ededler = new int[5] { 3, 10, 60, 6, 1 };
            
            int minimum = ededler[3];

            for (int i = 0; i < 5; i++)
            {
                int listelem = ededler[i];

                if (listelem < minimum)
                {
                    minimum = listelem;
                }
            }


            
            Console.WriteLine($"Listin minimumu: {minimum}");
        }
    }
}
