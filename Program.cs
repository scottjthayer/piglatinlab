using System;


namespace Capstone_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pig latin sentence translation machine bot program!");
            bool run = true;
            while (run)
            {
                Console.WriteLine("Please enter a sentence to be translated.");
                string input = Console.ReadLine().ToLower();
                string[] sentence = input.Split(" ");
                foreach (string s in sentence)
                {
                    Console.Write($"{Translate(s)} ");
                }

                Console.WriteLine("\nWould you like to run another beautiful sentence into the translator?");
                string yn = Console.ReadLine().ToLower().Trim();
                if (yn == "n")
                {
                    run = false;
                }
                else if (yn != "y")
                {
                    Console.WriteLine("That is not a valid entry. Please enter 'y' or 'n.'");
                    continue;
                }
            }
            Console.WriteLine("Thank you for using the pig latin sentence translation machine bot program!");
        }

        public static string Translate(string word)
        {            
                string addWay = "way";
                char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
                foreach (char ch in vowels)
                {
                    if (word[0] == ch)
                    {
                        return word + addWay;
                    }
                }

                int firstVowel = word.IndexOfAny(vowels);
                string firstPart = word.Substring(firstVowel);
                string secondPart = word.Substring(0, firstVowel);
                return firstPart + secondPart + "ay";
            
        }       
    }
}
