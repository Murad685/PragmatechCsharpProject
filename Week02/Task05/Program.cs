using System;

namespace Task05
{
    class Program
    {
        //Student adinda bir struct tanimlayin ve onun imtahan bali(grade) adinda bir propertysi olsun.
        //Ona kenardan dynamic olaraq 100 bal limitinde bir eded menimsedin.
        //Hemin ededi universitet imtahanlarinda bir fenden yigilan bala gore yoxlayin(araliqlari ozunuz qoyun).
        //Ex: 91-le 100 arasindadirsa girilen deyer ekrana "tebrikler siz A aldiniz" cixarin.
        struct Student
        {
            public byte bal { get; set; }

            public Student(byte grade)
            {
                this.bal = grade;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Imtahandan aldiginiz bali daxil edin: ");
            Student student = new Student(Convert.ToByte(Console.ReadLine()));
            
            if (student.bal >= 0 && student.bal < 51)
            {
                Console.WriteLine("Teessuf edirik ((KESR)) F");
            }
            else if (student.bal >= 51 && student.bal<61)
            {
                Console.WriteLine("Tebrikler imtahandan E aldiniz");
            }
            else if (student.bal >= 61 && student.bal < 71)
            {
                Console.WriteLine("Tebrikler imtahandan D aldiniz");
            }
            else if (student.bal >= 71 && student.bal < 81)
            {
                Console.WriteLine("Tebrikler imtahandan C aldiniz");
            }
            else if (student.bal >= 81 && student.bal < 91)
            {
                Console.WriteLine("Tebrikler imtahandan B aldiniz");
            }
            else if (student.bal >= 91 && student.bal <= 100)
            {
                Console.WriteLine("Tebrikler imtahandan A aldiniz!!");
            }
            else
            {
                Console.WriteLine("Melumat yanlisdir!!");
            }
        }
    }
}
