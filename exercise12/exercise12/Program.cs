using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        // Program imitates the game of hangman. User quesses the letters trying to quess the word. Program has preset amount of words, on which it decides one of them randomly.
        static void Main(string[] args)
        {
            // List of words which the program selects
            string[] words = { "hello", "beauty", "weather", "forest" };

            // randomizing and converting the word
            Random random = new Random();
            int randomIndex = random.Next(0, 4);
            string selectedWord = words[randomIndex];
            string hiddenWord = "";

            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }

            // quessing the word

            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0}", hiddenWord);
                Console.WriteLine("Quess a letter: ");
                char letter = char.Parse(Console.ReadLine());
                bool containsletter = false;

                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsletter = true;

                    }
                }
                if (containsletter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your quess {0} was in the word", letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your quess {0} was in the word", letter);
                }

                Console.ResetColor();
            }
            // winning the game

            Console.WriteLine("Congrats for winning the game. The word was {0}", selectedWord);
        }
    }
}