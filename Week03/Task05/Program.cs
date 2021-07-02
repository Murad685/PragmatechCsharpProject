using System;

namespace Task05
{
    class Program
    {
        public static string[] adlar;
        static void Main(string[] args)
        {
            /*
             * Ele bir program yazin ki,client-den nece ad daxil etmek istediyini sorushun.
             * Eded daxil edilsin.Eger eded tek ededdirse ekrana "zehmet olmasa cut eded daxil edin." cixarilsin ve 
             * cut eded daxil edilene qeder clientden sorushulsun ve eyni qaydada client eded daxil etsin.
             * Eger eded cut ededdirse ededin olcusunde string tipde adlar arrayi yaradilsin.
             * Clientden arrayi doldurmaq ucun adlar daxil etmeyini isteyin.
             * Bunu "1.adi daxil edin" sheklinde yazin.daxil edilen adin adlar arrayinin icinde olub olmamasini yoxlayin,
             * eger yoxdursa adlar arrayina menimsedin,eger varsa "Bu ad artiq daxil edilib,
             * bashqa ad daxil edin" mesajini cixarib qaldigi yerden davam edin doldurmaga.
             * Note:Arrayin bosh ve ya null deyerli indexi qalmamalidi.
             * Daha sonra birinci ve ikinci komanda adinda iki string tipde array yaradin.
             * Daha sonra sifirdan adlar arrayinin olcusune qeder random ededler goturub hemin ededlerin adlar arrayindeki
             * qarshiligi olan adlari birinci ve ikinci komandalara daxil edin.
             * Note:Adlar beraber sayda daxil edilmeli ve komandalarda tekrar adlar ishledilmemelidir.
             * Arrayler doldurulduqdan sonra ekrana her iki arrayin de neticeleri cixarilmalidir.
             */

            //Ele bir program yazin ki,client-den nece ad daxil etmek istediyini sorushun.
            Console.WriteLine("Nece ad daxil etmek isteyirsiniz?");

            //Eded daxil edilsin.
            
            int say;
            
            while (true)
            {

                
                say = Convert.ToInt32(Console.ReadLine());

                if (say % 2 == 1)
                {
                    Console.WriteLine("Zehmet olmasa cut eded daxil edin");

                }
                else
                {
                    adlar = new string[say];

                    for (int i = 0; i < say; i++)
                    {

                    //Bunu "1-ci adi daxil edin","2-ci adi daxil edin" sheklinde yazin
                    x:
                        Console.WriteLine($"{i + 1}-ci adi daxil edin");

                        string ad = Console.ReadLine();
                        //Bu hissede problem cixdi, heleki problemin niyesibi tapa bilmemisem 
                        foreach (var item in adlar)
                        {
                            if (ad == item)
                            {
                                Console.WriteLine("Bu ad artiq daxil edilib, bashqa ad daxil edin");

                                Console.WriteLine($"{i + 1}-ci adi daxil edin");
                                ad = Console.ReadLine();

                            }
                            else
                            {
                                //ad!=null && ad!=string.Empty
                                if (!string.IsNullOrEmpty(ad))
                                {
                                    adlar[i] = ad;
                                }
                                else
                                {
                                    Console.WriteLine("Bu melumat null ve ya empty ola bilmez!");
                                    goto x;
                                }
                            }
                        }


                    }
                }

                //Array komanda1 = new string[say / 2];
                //Array komanda3 = new string[say / 2];
                //Random rndm = new Random();
                //for (int i = 0; i < say; i++)
                //{
                //    rndm.Next(0, say);
                //    komanda1.SetValue(adlar.GetValue(rndm.Next(0, say)),i);
                //    foreach (var komandaindex in komanda1)
                //    {
                //        Console.WriteLine(komandaindex);
                //    }
                //}
            }

            




        }
    }
}
