using System;

namespace Task03
{
    class Program
    {
        //Iki string tipde array goturun ve onlara en az iki elementi duplicate olan deyer menimsedin ve
        //birinci arrayle ikinci arrayi muqaise edib oxshar deyerleri ve onlarin sayini ekrana cixardin.
        static void Main(string[] args)
        {
            
            string[] listOne = new string[5] { "a","b","c","d","e" };
            string[] listSecond = new string[5] { "d", "f", "g", "c", "o" };
            int say = 0;
            
            foreach (var itemSecond in listSecond)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (listOne[i]==itemSecond)
                    {
                        
                        say++;
                        Console.WriteLine("Dublicate olan element: "+ itemSecond);
                        
                    }
                   
                }
                


            }
            Console.WriteLine("Umumi say : " +say);


        }
    }
}
