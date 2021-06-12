using System;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ele bir program yazin ki, qarshinizdaki insandan adini ve soyadini sorushun.
            //Aldiginiz cavablari deyishenlere menimsedin ve sual verdiyiniz adama adini cekerek consoleda salam deyin.
            string ad;
            string soyad;
            Console.WriteLine("Zehmet olmasa Adinizi daxil edin");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadiniz daxil edin:");
            soyad = Console.ReadLine();
            Console.WriteLine($"Salam {ad} {soyad} dostum,necesen?");
            Console.ReadLine();
        }
    }   
}
