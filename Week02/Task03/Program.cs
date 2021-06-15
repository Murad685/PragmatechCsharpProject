using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic olaraq daxil edilmish integer deyerin tek ve ya cut eded olmasini yoxlayin.
            int a;
            Console.WriteLine("Eded daxil et:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 1)
            {
                Console.WriteLine("Tek ededdir!");
            }
            else
            {
                Console.WriteLine("Cut ededdir!");
            }
        }
    }
}
