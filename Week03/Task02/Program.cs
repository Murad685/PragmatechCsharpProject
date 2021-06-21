using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Do while-dan ve Random class-dan istifade ederek Eded texmin oyunu qurun.
             * Random bir eded goturun ve kenardan daxil edeceyiniz ededle ust uste dushene qeder programi dayanmadan ishledin.
             * 5 eded texmin etmek shansiniz var.
             * Eger texmin haqqiniz dogru ededi tapmadan bitmishse ekrana "Sizin texmin haqqiniz bitmishdir" 
             * ve Tutulan ededi ekrana cixardin.
             * "Yox eger texmin haqqiniz bitmeden ededler ust uste dusherse console-a "Tebrikler siz duz tapdiniz" cixarin.
             * Bundan elave eger texmin edilen eded tutulan ededden kicikdirse client-i yonlendirin ve
             * "Daxil etdiyiniz eded tutulan ededden kicikdir." cixarin console-a.
             * Yox eger tersinedise "Daxil etdiyiniz eded tutulan ededden boyukdur.
             */
            
            Random accidental = new Random();
            int i = accidental.Next(1,11);
            Console.WriteLine(i);
            Console.WriteLine("1 ve 10 arasi eded daxil edin:");
            int j;
            int f = 1;

            do
            {
                j = Convert.ToInt32(Console.ReadLine());
                if (i == j)
                {
                    Console.WriteLine($"Tebrikler siz duz tadpiniz.Proqramin fikrinde tutdugu reqem {i} idi.");
                    break;
                }
                else if ( i>j && j<= 10 && j > 0)
                {
                    Console.WriteLine("Daxil etdiyiniz eded tutulan ededden kicikdir.");
                }
                else if ( i < j && j <= 10 && j>0)
                {
                    Console.WriteLine("Daxil etdiyiniz eded tutulan ededden Boyukdur.");
                }
                else 
                {
                    Console.WriteLine($"Sistemde bele bir eded yoxdur! Yeniden eded daxil edin,{f}-ci gedisdesiniz");
                }
                f++;
            } while (f<6);
            if (f > 5)
            {
                Console.WriteLine("Tessuf Sizin texmin haqqiniz bitmishdir!");
            }




        }
    }
}
