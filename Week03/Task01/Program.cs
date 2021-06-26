using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Do while-dan istifade ederek ele bir program yazin ki,
             * ekrana eded daxil edin mesaji cixsin,ardinca eded daxil edilsin,
             * daxil edeceyimiz eded 0 olana qeder ishlesin ve nevaxt ki,
             * 0 daxil etdik o zaman evvel daxil etdiyimiz ededlerin cemini de ekrana cixarsin.
             */
            
            int i;
            int j = 0;
            do
            {
                
                Console.WriteLine("Eded daxil edin:");
                i = Convert.ToInt32(Console.ReadLine());
                j += i;
                
            } while (i != 0);
            Console.WriteLine($"Daxil etdiyiniz ededlerin cemi {j}");

        }
    }
}
