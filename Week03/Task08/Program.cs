using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Console-a a-dan z-ye qeder herfleri cixardin.
             */
            char[] elifba = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'}; 
            foreach (var item in elifba)
            {
                Console.WriteLine(item);
            }
        }
    }
}
