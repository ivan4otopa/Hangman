namespace Hangman
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    class Play
    {
        private static string wordToGuess = "";
        private static List<string> guessedLetters = new List<string>();
        private static bool hasWon = false;
        private static string wordByNow = "";
        private static Hangman hangman = new Hangman();

        static void Main()
        {
            Console.Write("Enter the word to guess: ");

            wordToGuess = Console.ReadLine();

            while (wordToGuess == "")
            {
                Console.Clear();
                Console.Write("Can't play with an empty word\nEnter the word to guess: ");

                wordToGuess = Console.ReadLine();
            }

            while (hangman.Lives > 0)
            {
                UpdateWordByNow();

                CheckHasWon();

                if (hasWon)
                {
                    break;
                }

                PrintResult();

                Console.Write("Enter a character: ");

                string character = Console.ReadLine();

                while (character == "")
                {
                    PrintResult();

                    Console.WriteLine("Can't proceed if you don't enter a letter");                    
                    Console.Write("Enter a character: ");

                    character = Console.ReadLine();
                }

                if (CharExists(character))
                {
                    Console.WriteLine("You guessed right!");

                    guessedLetters.Add(character);
                }
                else
                {
                    hangman.Lives--;

                    Console.WriteLine("You guessed wrong!");
                }

                Thread.Sleep(2000);
            }

            Console.Clear();

            if (!hasWon)
            {
                Console.WriteLine("{0}\nGame Over!", hangman.Print());
            }
            else
            {
                Console.WriteLine("{0}\nYou won!", wordToGuess);
            }
        }

        static void UpdateWordByNow()
        {
            wordByNow = "";

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (guessedLetters.Contains(wordToGuess[i].ToString()))
                {
                    wordByNow += wordToGuess[i];
                }
                else
                {
                    wordByNow += "*";
                }
            }
        }

        static bool CharExists(string character)
        {
            if (wordToGuess.IndexOf(character) > -1)
            {
                return true;
            }

            return false;
        }

        static void CheckHasWon()
        {
            if (!wordByNow.Contains("*"))
            {
                hasWon = true;
            }
        }

        static void PrintResult()
        {
            Console.Clear();
            Console.WriteLine(
                "{0}\nLives: {1}\nWord by now: {2}",
                hangman.Print(),
                hangman.Lives,
                wordByNow);
        }
    }
}