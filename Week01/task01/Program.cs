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
            string name = "Murad";
            string surname = "Orujov";
            int age = 21;
            string uni= "ADNSU";
            string ixtisas = "Information Technology";

            Console.WriteLine($"Hello, my name is {name}, my surname is {surname}. I am {age} years old." +
                $" I am studying at the Department of {ixtisas} of {uni} University");
            
        }
    }
}