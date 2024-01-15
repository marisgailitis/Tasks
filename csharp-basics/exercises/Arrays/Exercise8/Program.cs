using System;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace Exercise8
{
    internal class Program
    {
		private static List<string> _words = new List<string>(){"someword", "someotherword", "somelongestword"};
		private static int _numberOfTries;
		private static char[] _pickedWord;
		private static char _guess;
		private static char[] _progress;
		private static StringBuilder _misses = new StringBuilder();
		private static int _attemptsLeft;
		private static int _lettersToGuess;
		private static string _underline = "-=-=-=-=-=-=-=-=-=-=-=-=-=-";
		private static bool gameOver;

        static void Main(string[] args)
        {
            while(!gameOver)
			{
				Initialize();
				_attemptsLeft = 15;

				Display();

				while(_attemptsLeft > 0 && _lettersToGuess > 0)
				{
					GetGuess();
					Display();
					Console.WriteLine($"Attemmpts : {_attemptsLeft} and to guess : {_lettersToGuess}");
				}

				GetResult();
				PlayOrQuit();
			}
        }

		private static void Initialize()
		{
			Random random = new Random();
			_pickedWord = _words[random.Next(0, _words.Count)].ToCharArray();
			int length = _pickedWord.Length;
			_progress = new char[length];
			_lettersToGuess = length;

			for(int i = 0; i < length; i++)
			{
				_progress[i] = '_';
			}
		}

		private static void Display()
		{
			Console.WriteLine(_underline);
			Console.WriteLine($"Word : {string.Join(" ", _progress)}");
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
					_attemptsLeft--;
					_lettersToGuess--;
					return;
				}
			}

			if(!charFound)
			{
				_misses.Append(guess);
			}

			_attemptsLeft--;
		}

		private static void GetResult()
		{
			if(_lettersToGuess == 0)
				Console.WriteLine($"You won!");
			else
				Console.WriteLine($"You Lost");
		}
		private static void PlayOrQuit()
		{
			bool answerGiven = false;
			while(!answerGiven)
			{
				Console.WriteLine($"Play 'again' or 'quit'?");
				string decision = Console.ReadLine();
				Console.WriteLine(decision);

				if(decision == "again")
				{
					_misses.Clear();
					answerGiven = true;
				}
				else if(decision == "quit")
				{
					gameOver = true;
					answerGiven = true;
				}
				else
				{
					Console.WriteLine($"Please give a correct answer");
				}
			}
		}
    }
}