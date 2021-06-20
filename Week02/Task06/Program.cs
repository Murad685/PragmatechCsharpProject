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

            public Person(string username, string usersurname, byte userage)
            {
                this.Name = username;
                this.Surname = usersurname;
                this.Age = userage;
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Username:");
            string usrname = Console.ReadLine();
            Console.WriteLine("Enter Usersurname");
            string usrsurname = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            byte userage = Convert.ToByte(Console.ReadLine());
            Person person = new Person("Murad","Orucov",userage);

            if (person.Name== usrname && person.Surname==usrsurname)
            {
                if (userage < 18)
                {
                    
                    Console.WriteLine("Sizin yasiniz uygun deyil");
                }
                else
                {
                    Console.WriteLine("Sizin yasiniz uygundur");
                }
            }
            else if (person.Name != usrname && person.Surname != usrsurname && userage < 18)
            {
                Console.WriteLine("WRONG Username, Password and Inappropriate age");
            }
            else
            {
                Console.WriteLine("WRONG Username or Password");
            }
        }


    }
}
