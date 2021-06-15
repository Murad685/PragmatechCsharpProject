using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic olaraq daxil edilmish integer deyerin musbet ve ya menfi eded olmasini yoxlayin.
            int a;
            Console.WriteLine("Eded daxil et:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Eded menfidir!");
            }
            else if (a >0)
            {
                Console.WriteLine("Eded musbetdir!");
            }
            else
            {
                Console.WriteLine("Eded sifirdir!");
            }
        }
    }
}
