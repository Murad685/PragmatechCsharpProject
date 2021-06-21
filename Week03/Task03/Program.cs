using System;

namespace Task03
{
    class Program
    {
        /*
         * Istifadecinin dynamic olaraq daxil etdiyi ededin faktorialini tapin.
         * Daxil edilen ededin sifir olmasi ehtimalinin qarshisini alin.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin:");
            int eded = Convert.ToInt32(Console.ReadLine());
            int factor = 1;
            if (eded==0)
            {
                Console.WriteLine("Factorial 0-dir");
            }
            for (int i=1; i <= eded ; i++)
            {

                factor = factor * i; 
                
            }
            Console.WriteLine($"factorial={factor}");
        }
    }
}
