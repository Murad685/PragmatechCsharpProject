using System;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ele bir program yazin ki, o programda ozunuze aid olan melumatlari gostere bilesiniz.
            //Adiniz, soyadiniz,yashiniz ve universitet adini uygun deyishenlere menimsederek consoleda gosterin.
            //Deyishenlere deyerler kenardan oz elimizle daxil edeceyik.

            string ad;
            string soyad;
            int yash;
            string uni;
            string ixtisas;
            Console.WriteLine("Zehmet olmasa adinizi daxil edin:") ;
            ad = Console.ReadLine();
            Console.WriteLine("Indi soyadinizi daxil edin:");
            soyad = Console.ReadLine();
            Console.WriteLine("Affferin novbeti addima kecdiniz, yasinizi daxil edin:");
            yash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tehsil aldiginiz Universitetin adini daxil edin (qisaltma fromasinda):");
            uni = Console.ReadLine();
            Console.WriteLine("Meni aldatma melumat yalnsdir:");
            uni = Console.ReadLine();
            Console.WriteLine("Hahahahahaha bu bir zarafat idi. Oxudugunuz ixtisatin tam adini daxil edin:");
            ixtisas = Console.ReadLine();
            Console.WriteLine("Tebrikler!, Sizinle islemek xos idi");

        }
    }
}
