using System;

namespace Task06
{
    class Program
    {
        /*Person adinda struct goturun,Name,Surname,Age adinda property-leri olsun.
            Name ve Surname constructorun icinde initialize edilsin ve hardcode deyerler alsin. 
            Age ise constructor cagirildiqdan sonra dynamic olaraq kenardan daxil edilsin.
            Daha sonra Name ve Surname adinda iki deyishen goturun ve onlara da dynamic deyerler menimsedin. 
            Evvelce girilen ad soyadin qabaqcadan goturulmush ad soyadla ust-uste dushub dushmediyini yoxlayin,
            daha sonra eger result true olarsa age-i yoxlayin 18den kicikdirse console "Sizin yashiniz uygun deyil cixardin".
            Boyuk olarsa uygundur cixardin.*/
        struct Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public byte Age { get; set; }

            public Person(string username,string usersurname, byte userage)
            {
                this.Name = username;
                this.Surname = usersurname;
                this.Age = userage;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            Person person = new Person("Murad", "Orucov", Convert.ToByte(Console.ReadLine()));
            string usrname;
            string usrsurname;
            if (person.Age >= 18)
            {
                Console.WriteLine("Sizin yasiniz uygundur. Enter Username:");
                usrname = Console.ReadLine();
                Console.WriteLine("Enter Usersurname");
                usrsurname = Console.ReadLine();
                if (person.Name == usrname && person.Surname == usrsurname)
                {
                    Console.WriteLine("Welcome to Site");
                }
                else
                {
                    Console.WriteLine("WRONG Username or Password");
                }
            } 
            else
            {
                Console.WriteLine("Sizin yasiniz uygun deyil ");
            }
        }
    }
}
