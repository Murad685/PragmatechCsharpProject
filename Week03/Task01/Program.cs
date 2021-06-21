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
            Console.WriteLine("Eded daxil edin:");
            int i;
            int j=0;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                j += i;
                if (i == 0)
                {
                    
                    break;
                    
                }
                
            } while (true);
            Console.WriteLine($"Daxil etdiyiniz ededlerin cemi {j}");

        }
    }
}
