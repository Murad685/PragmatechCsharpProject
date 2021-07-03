using System;
using System.Linq;

namespace Task06_first_method
{
    class Program
    {
        //Arrayin minimum elementini tapin.
        static void Main(string[] args)
        {
            int[] ededler = new int[] { 3, 10, 60, 6, 1 };
            int min = ededler.Min();
            Console.WriteLine($"Listin minimumu: {min}");
        }
    }
}
