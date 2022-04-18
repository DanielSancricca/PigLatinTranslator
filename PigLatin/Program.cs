using System;
using System.Text;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        { bool goAgain = true;
            while (goAgain == true)
            {
                Console.WriteLine("Please enter English text to be translated into Pig Latin.");
                string userInput = Console.ReadLine().ToLower();

                string[] words = userInput.Split(" ");
                string pigLatinSentence = "";

                foreach (string word in words)
                {
                    pigLatinSentence += PigLatinWordTranslation(word) + " ";

                }

                Console.WriteLine(pigLatinSentence);
                
                while (true)
                {
                    Console.WriteLine("Would you like to translate another sentence? Please press y or n.");
                    string userResponse = Console.ReadLine().ToLower();
                    if (userResponse == "y")
                    {
                        break;
                    }
                    else if (userResponse == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        goAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't understand your entry. Please enter y or n.");
                    }

                }

            }















        }
















        static string PigLatinWordTranslation(string userWord)
        {            
            int vowelPosition = -1;
            foreach (char letter in userWord)
            {
                vowelPosition = vowelPosition + 1;
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    break;
                }
            }
            string pigLatinWord = "";
            string beforeLetters = "";
            string afterLetters = "";

            if (vowelPosition == 0)
            {
                pigLatinWord = userWord + "way";
            }
            else if (vowelPosition == 1)
            {
                beforeLetters = userWord.Substring(0, 1);
                afterLetters = userWord.Substring(1);
                pigLatinWord = afterLetters + beforeLetters + "ay";
            }
            else if (vowelPosition == 2)
            {
                beforeLetters = userWord.Substring(0, 2);
                afterLetters = userWord.Substring(2);
                pigLatinWord = afterLetters + beforeLetters + "ay";
            }
            else if (vowelPosition == 3)
            {
                beforeLetters = userWord.Substring(0, 3);
                afterLetters = userWord.Substring(3);
                pigLatinWord = afterLetters + beforeLetters + "ay";
            }
            else
            {
                pigLatinWord = "I'm sorry this is not a word in English.";
            }

            return pigLatinWord;


        }

    
    }
}
    