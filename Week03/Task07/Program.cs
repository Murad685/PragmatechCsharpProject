using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10 olculu int tipde array tanimlayin.
             * 0-dan 10-a qeder 10 daxil olmamaqla random ededleri hemin arraye daxil edin.
             * Note:bir ededi iki defe daxil etmek olmaz.
             * Sonda yaranan array listi ve eyni ededden birden artiq yaranibsa onlarin sayini ekrana cixardin.
             */
            //10 olculu int tipde array tanimlayin.

            Random tesadufieded = new Random();

            int[] list = new int[10];
            
            int i = 0;
            int tekraksayi = 0;
            while ( i < 10 )
            {
                // 0-dan 10-a qeder 10 daxil olmamaqla random ededleri hemin arraye daxil edin.
                list[i] = tesadufieded.Next(0, 10);
                go:
                if (i > 0)
                {
                    //Note:bir ededi iki defe daxil etmek olmaz.
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (list[j] == list[i])
                        {
                            list[i] = tesadufieded.Next(10);
                            
                            tekraksayi++;
                            goto go;
                        }
                    }
                }
                i++;
            }
            //Sonda yaranan array listi ve eyni ededden birden artiq yaranibsa onlarin sayini ekrana cixardin.


            Console.WriteLine($"Tekrar olunmanin sayi: {tekraksayi}.");
        }
    }
}
