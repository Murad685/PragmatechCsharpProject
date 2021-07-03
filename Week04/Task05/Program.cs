using System;
using System.Linq;

namespace Task05
{
    class Program
    {
        //Cut ve tek ededlerden ibaret olan int tipli arrayin icinden cut ededleri silin.
        static void Main(string[] args)
        {
            int[] list = new int[25];
            Random randomNumber = new Random();
            int i = 0;
            while (i < list.Length)
            {
                list[i] = randomNumber.Next(0, 25);

                if (list[i] % 2 == 0)
                {
                    list = list.Where((source, index) => index != i).ToArray();
                }
                i++;
            }
              
            Console.WriteLine("Listin elementler: "+ String.Join(',', list));

           

        }
    }
}
