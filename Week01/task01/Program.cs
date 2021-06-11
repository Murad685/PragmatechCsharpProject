using System;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ele bir program yazin ki, o programda ozunuze aid olan melumatlari gostere bilesiniz.
            //Adiniz, soyadiniz,yashiniz ve universitet adini consoleda gosterin.
            //Qeyd:Deyishenlere deyerler hard code sheklinde verilsin.
            string ad = "Murad";
            string soyad = "Orucov";
            int yash = 21;
            string uni= "ADNSU";
            string ixtisas = "Informasiya Texnologiyalari";

            Console.WriteLine("Ad: "+ad) ;
            Console.WriteLine("Soyad: "+soyad) ;
            Console.WriteLine("Yash: "+ yash) ;
            Console.WriteLine("Universitet: "+uni) ;
            Console.WriteLine("Ixtisas: "+ixtisas) ;
        }
    }
}
