using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ele bir program yazin ki,client-a bir eded daxil etmesini deyin.
             * Client daxil etdiyi eded olcusunde string array tanimlayin. 
             * Client-den arraye onun olcusu qeder ad daxil etmesini isteyin.
             * Bunu "1-ci adi daxil edin","2-ci adi daxil edin" sheklinde yazin. 
             * Daha sonra clientden hansi adi secmek istediyini sorushun.
             * Secilen addan evvelceden daxil edilen adlarin icinde nece dene olmasini tapin ve 
             * ekrana secilen adi ve nece dene olmasini cixardin.
             */
            //Ele bir program yazin ki,client-a bir eded daxil etmesini deyin
            Console.WriteLine("Bir eded daxil edin:");
            int eded = Convert.ToInt32(Console.ReadLine());

            //Client daxil etdiyi eded olcusunde string array tanimlayin. 
            string[] myarray = new string[eded];

            //Client-den arraye onun olcusu qeder ad daxil etmesini isteyin
            Console.WriteLine($"Zehmet olmasa {eded} eded ad daxil edin:");

            for (int i = 0; i < eded; i++)
            {
                //Bunu "1-ci adi daxil edin","2-ci adi daxil edin" sheklinde yazin
                Console.WriteLine($"{i+1}-ci adi daxil edin");
                myarray[i]= Console.ReadLine();
            }

            //Daha sonra clientden hansi adi secmek istediyini sorushun
            Console.WriteLine("Hasi adi cekmek isteyirsiniz?");
            string ad = Console.ReadLine();
            //Secilen addan evvelceden daxil edilen adlarin icinde nece dene olmasini tapin ve
            int say = 0;
            foreach(var defaultad in myarray)
            {

                if (defaultad == ad)
                {
                    say += 1;

                    // ekrana secilen adi ve nece dene olmasini cixardin.
                    Console.WriteLine($"Daxil etdiyniz ad siyahida {say} ededdir.");
                }
                

            }
            
            
        }
    }
}
