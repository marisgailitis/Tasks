using System;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace Exercise8
{
    internal class Program
    {
		private static List<string> _words = new List<string>(){"someword", "someotherword", "somelongestword"};
		private static int _numberOfTries = 15;
		private static char[] _pickedWord;
		private static char _guess;
		private static char[] _wordInProgress;
		private static StringBuilder _misses = new StringBuilder();
		private static int _attemptsLeft;
		private static int _lettersLeft;
		private static string _underline = "-=-=-=-=-=-=-=-=-=-=-=-=-=-";
		private static bool gameOver;

        static void Main(string[] args)
        {
			while(true)
			{
				Initialize();
				_attemptsLeft = _numberOfTries;

				Display();

				while(_attemptsLeft > 0 && _lettersLeft > 0)
				{
					GetGuess();
					Display();
					Console.WriteLine($"Attemmpts : {_attemptsLeft} and to guess : {_lettersLeft}");
				}

				GetResult();
				
				if (!PlayAgain())
                {
                    break;
                }
			}
        }

		private static void Initialize()
		{
			Random random = new Random();
			_pickedWord = _words[random.Next(0, _words.Count)].ToCharArray();
			int length = _pickedWord.Length;
			_wordInProgress = new char[length];
			_lettersLeft = length;

			for(int i = 0; i < length; i++)
			{
				_wordInProgress[i] = '_';
			}
		}

		private static void Display()
		{
			Console.WriteLine(_underline);
			Console.WriteLine($"Word : {string.Join(" ", _wordInProgress)}");
			Console.WriteLine($"Misses : {_misses}");
			Console.WriteLine($"Guess : {_guess}");
		}

		private static void GetGuess()
		{
			string input = Console.ReadLine();
			char guess = input[0];

			bool charFound = false;

			for(int i = 0; i < _pickedWord.Length; i++)
			{
				if(_pickedWord[i] == guess)
				{
					_pickedWord[i] = '_';
					_progress[i] = guess;
					charFound = true;
					_lettersLeft--;
					return;
				}
			}

			if(!charFound)
			{
				_misses.Append(guess);
				_attemptsLeft--;
			}
		}

		private static void GetResult()
		{
			if(_lettersLeft == 0)
				Console.WriteLine($"You won!");
			else
				Console.WriteLine($"You Lost");
		}
		
		private static bool PlayOrQuit()
		{
			Console.WriteLine($"Play 'again' or 'quit'?");

			while(true)
			{
				string decision = Console.ReadLine();
				Console.WriteLine(decision);

				if(decision == "again")
				{
					_misses.Clear();
				}
				else if(decision == "quit")
				{
					Environment.Exit(0);
				}
				else
                {
                    Console.WriteLine("Invalid decision. Type 'again' or 'quit'.");
                }
			}
		}
    }
}