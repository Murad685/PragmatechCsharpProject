using System;

namespace Task01
{
    class Program
    {
        //Bir struct tanimlayin,iki property-si olsun.
        //Username ve Password adinda.Uygun olaraq string ve int tiplerinde.
        //Ve hemin property-leri Struct-in constructorunda initialize edin,hardcode olaraq username ve passworda deyer tanimlayin.
        //Daha sonra Console-a "UserName daxil edin" cixardin.Dynamic olaraq userName daxil edin ve deyishene menimsedin.
        //Eyni shekilde "PassWord daxil edin" cixardin.Dynamic olaraq passWord daxil edin ve deyishene menimsedin.
        //Daxil edilmish deyerleri hardcode yazilmish deyerlerle muqaise edin,eger uygundursa Console-a "sayta xosh gelmisiniz" yazisi cixardin.
        //Deyilse "UserName ve ya PassWord yalnishdir" cixardin.
        //Bu emeliyyatlarin hamisini bir programda edin. Bitirdikden sonra Console-u dynamic olaraq temizleyin.
        struct Login
        {
            public string Username { get; set; }
            public int Password { get; set; }

            public Login(string Username,int Password)
            {
                this.Username = "muradorucow";
                this.Password = 2000;
            }
        }
        static void Main(string[] args)
        {
            Login userlogin = new Login("murad", 2000);
            string user;
            int password;
            Console.WriteLine("Enter USername:");
            user = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            password =Convert.ToInt32(Console.ReadLine());

            if (userlogin.Username == user && userlogin.Password==password)
            {
                Console.WriteLine("Welcome to Site");
            }
            else
            {
                Console.WriteLine("WRONG Username or Password");
            }
        }
    }
}
