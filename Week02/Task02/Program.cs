using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daxil edilmish iki ededden hansinin boyuk hansinin kicik ve ya beraber olduqlarini yoxlayin.
            int a =3;
            int b=90;

            if (a > b)
            {
                Console.WriteLine("Birinci boyukdur ikinciden");
            }
            else if (b > a)
            {
                Console.WriteLine("Ikinci boyukdur Birinciden");
            }
            else
            {
                Console.WriteLine("Beraberdirler");
            }

            /* Məsələnin şərtində ədədlərin dynamic olaraqmı yoxsa əvvəlcədn daxil edilmiş olmasını tam anlamdığım səbəbindən hər iki hal üçün proqram qurdum.
            aşağıdakı program isə dynamic olaraq daxil edilmiş ədədlərin müqayisəsinə aiddir.
            
            int a;
            int b;

            Console.WriteLine("Birinci ededi daxil et");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil et");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Birinci boyukdur ikinciden");
            }
            else if (b > a)
            {
                Console.WriteLine("Ikinci boyukdur Birinciden");
            }
            else
            {
                Console.WriteLine("Beraberdirler");
            }*/
        }
    }
}
