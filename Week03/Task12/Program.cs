using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-den 10-a qeder vurma cedvelini Console-a cixardin.
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int hasil = j * i;
                    Console.WriteLine($"{ j} * {i} = {hasil}");
                }
            }
        }
    }
}
