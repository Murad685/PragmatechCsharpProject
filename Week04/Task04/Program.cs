using System;
using System.Collections;

namespace Task04
{
    class Program
    {
        //Sport komplekse qeydiyyat sistemi qurun.Bir arraylist goturun.
        //Bashliq olaraq "Sport komplekse qeydiyyat sistemi" yazin.
        //Daha sonra "Edeceyiniz emeliyyati secin" yazilsin.
        //Altinnan "1-Uzv daxil edin", "2-Uzvu qeydiyyatdan silin", "3-Uzvlerin Listini gorun",
        //"4-Uzvlerin siyahini ters cevirin", "5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin",
        //"6-Uzvlerin Listini bashdan sona siralayin", "7-Butun uzvlerin qeydiyyatini silin",
        //"8-Sport komlekse qeydiyyat sisteminden cixin" Sonra dynamic olaraq qarshisindaki kodlara gore emeliyyati secirsiniz.
        //Secdiyiniz emeliyyati switch ile yoxlayib teleb olunan emeliyyatlari yerine yetirirsiniz.
        //Note: Her emeliyyata daxil olarken ekrana bele bir mesaj cixsin hemin emeliyyatla bagli
        //"Uzv daxil etme ekranina xosh geldiniz".
        //1-ci emeliyyatda uzv daxil etmezden once daxil edilecek uzv sayi sorushulsun,sonra dynamic olaraq daxil edilsin.
        //2-ci emeliyyati yerine yetirerken evvelce daxil edilmish datalarin listi gelsin
        //daha sonra silmek istediyiniz uzvun adi sorushulsun,
        //dynamic olaraq daxil edilsin ve silme emeliyyati aparilsin. 4-cu emeliyyatda da evvelce datanin listi gelsin ekrana,
        //daha sonra emeliyyati yerine yetirin. 5-ci emeliyyatda evvelce yoxlamaq istenilen uzvun adi sorushulsun ve
        //sonra dynamic olaraq daxil edilsin. Ve butun emeliyyatlarin sonunda hemin emeliyyat ugurla basha catdi deyilsin.
        //"Enteri vurun" mesaji gelsin,enteri vuranda yeniden en basha qayitsin proses tekrarlansin.
        static void Main(string[] args)
        {
            ArrayList userList = new ArrayList();
            
            Console.WriteLine("||||| Sport komplekse qeydiyyat sistemi: |||||");
        go:
            Console.WriteLine("\n////Edeceyiniz emeliyyati secin: ////");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1-Uzv daxil edin:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("2-Uzvu qeydiyyatdan silin:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("3-Uzvlerin Listini gorun:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("4-Uzvlerin siyahini ters cevirin:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("6-Uzvlerin Listini bashdan sona siralayin");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("7-Butun uzvlerin qeydiyyatini silin");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("8-Sport kompleks qeydiyyat sisteminden cixin");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ememliyyati daxil edin:");

            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            switch (number)
            {

                case 1:
                    Console.WriteLine("\n|||| Uzv daxil etme ekranina xosh gelmisiniz: ||||");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Nece uzuv daxil etmek isteyirsiniz?");
                    int userNumeral = Convert.ToInt32(Console.ReadLine());

                    while (i < userNumeral)
                    {
                        Console.WriteLine($"{i + 1}-ci adi daxil edin");
                        userList.Add(Console.ReadLine());
                        i++;
                    }
                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun ! ");
                    string key = Console.ReadLine();
                    
                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }

                case 2:

                    Console.WriteLine("|||| Uzvler listi: ||||");
                    Console.WriteLine("------------------------------------");
                    int length = userList.Count;
                    for (int j = 0; j < length; j++)
                    {
                        Console.WriteLine("{0} - {1}", j + 1, userList[j]);
                    }
                    Console.WriteLine("Silmek istediyiniz uzvun adi: ");
                    string username = Console.ReadLine();
                    userList.Remove(username);
                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun !");
                    key = Console.ReadLine();

                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }

                case 3:
                    Console.WriteLine("Uzvler listi:");
                    Console.WriteLine("------------------------------------");
                    length = userList.Count;
                    for (int j = 0; j < length; j++)
                    {
                        Console.WriteLine($"{j + 1} - {userList[j]}");
                    }
                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun !");
                    key = Console.ReadLine();

                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }
                case 4:
                    Console.WriteLine("Uzvlerin Listi: ");
                    Console.WriteLine("------------------------------------");
                    length = userList.Count;
                    for (int j = length-1; j>-1; j--)
                    {
                        Console.WriteLine($"{j + 1} - {userList[j]}");
                    }
                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun !");
                    key = Console.ReadLine();

                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }
                case 5:
                    Console.Write("Yoxlamaq istediyiniz uzvun adi: ");
                    Console.WriteLine("------------------------------------");
                    string checkName= Console.ReadLine();
                    if (userList.Contains(checkName))
                    {
                        Console.WriteLine("Daxil edilen ad sistemde var!");
                    }
                    else
                    {
                        Console.WriteLine("Daxil edilen ad sistemde yoxdur!");
                    }
                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun !");
                    key = Console.ReadLine();

                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }
                case 6:
                    Console.WriteLine("Siralanmis uzvler listi:");
                    Console.WriteLine("------------------------------------");
                    userList.Sort();
                    length = userList.Count;
                    for (int j = 0; j < length; j++)
                    {
                        Console.WriteLine($"{j + 1} - {userList[j]}");
                    }
                    Console.WriteLine();

                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun !");
                    key = Console.ReadLine();

                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }
                case 7:
                    userList.Clear();
                    Console.WriteLine();

                    Console.WriteLine("\n|||| Emeliyyat ugurla basha catdi! ||||");
                    Console.WriteLine("Basa qayitmaq ucun Enteri vurun !");
                    key = Console.ReadLine();

                    if (string.IsNullOrEmpty(key))
                    {
                        goto go;
                    }
                    else
                    {
                        break;
                    }
                case 8:
                    Console.WriteLine("|||||  Sistemden ugurla cixildi!.  |||||");
                    break;

            }
        }
    }
}
