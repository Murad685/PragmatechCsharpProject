using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Clientdan bir word daxil etmesini isteyin.
             * Hemin wordun terkibinde sait seslerin ishlenib ishlenmediyini ve
             * eger ishlenibse nece defe ishlendiyini tapib ekrana cixarin.
             */
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            int i = 0;
            char[] vowelArray = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
            foreach (var vowelSound in vowelArray)
            {
                
                foreach (var wordletter in wordArray)
                {
                    if (wordletter == vowelSound)
                    {
                        i++;
                                
                    }
                }
            }
            Console.WriteLine($"The number of vowels : {i}");
        }
    }
}
