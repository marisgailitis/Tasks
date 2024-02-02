using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TicTacToe
{
	class Program
	{
		private static char[,] _board;
		private static int _currentTurn = 0;
		private static char currentPlayer;

		private static void Main(string[] args)
		{
			InitBoard();
			DisplayBoard();

			bool gameOver = false;

			while (!gameOver && _currentTurn < 9)
			{
				GetPlayerMove();
				gameOver = CheckResult();
				DisplayBoard();
			}

			WriteWinnner();
		}

		private static void InitBoard()
		{
			_board = new char[3, 3];

			for (var r = 0; r < 3; r++)
			{
				for (var c = 0; c < 3; c++)
					_board[r, c] = ' ';
			}
		}

		private static void DisplayBoard()
		{
			for (int x = 0; x < 3; x++)
			{
				StringBuilder builder = new StringBuilder();

				builder.Append("| ");

				for (int y = 0; y < 3; y++)
				{
					builder.Append(_board[x, y]);
					builder.Append(" | ");
				}

				string upperLine = builder.ToString();
				string underline = "-------------";

				Console.WriteLine(upperLine);
				Console.WriteLine(underline);
			}
		}

		private static void GetPlayerMove()
		{
			currentPlayer = GetPlayerSymbol(_currentTurn);

			Console.WriteLine($"' {currentPlayer} ', choose your coordinates (row, column): ");
			string input = Console.ReadLine();
			string[] numbers = input.Split(' ');

			if (numbers.Length < 2) Console.WriteLine("The cell coordinates consist of two parameters");

			if (int.TryParse(numbers[0], out int row) && int.TryParse(numbers[1], out int col))
			{
				if (row < 0 || col < 0 || row > 2 || col > 2)
				{
					Console.WriteLine("The cell must fit in board margins");
					return;
				}

				//if the cell is free, fill it
				if (_board[row, col] == ' ')
				{
					_board[row, col] = currentPlayer;
					_currentTurn++;
					return;
				}
				Console.WriteLine("Input a cell that is not taken");
				return;
			}

			Console.WriteLine("Could not get the coordinates from the input");
		}

		private static char GetPlayerSymbol(int currentTurn)
		{
			return currentTurn % 2 == 0 ? 'X' : 'O';
		}

		private static bool CheckResult()
		{
			Console.WriteLine($"Current move {_currentTurn}");
			if (_currentTurn < 5) return false;

			bool firstPlayer = GetIndividualResult('X');
			bool secondPlayer = GetIndividualResult('O');

			return firstPlayer || secondPlayer;
		}

		private static bool GetIndividualResult(char player)
		{
			bool[] lineWon = new bool[8];

			lineWon[0] = CheckIndividualLine(new Point(0, 0), new Point(0, 1), player);
			lineWon[1] = CheckIndividualLine(new Point(1, 0), new Point(0, 1), player);
			lineWon[2] = CheckIndividualLine(new Point(2, 0), new Point(0, 1), player);
			lineWon[3] = CheckIndividualLine(new Point(0, 0), new Point(1, 0), player);
			lineWon[4] = CheckIndividualLine(new Point(0, 1), new Point(1, 0), player);
			lineWon[5] = CheckIndividualLine(new Point(0, 2), new Point(1, 0), player);
			lineWon[6] = CheckIndividualLine(new Point(0, 0), new Point(1, 1), player);
			lineWon[7] = CheckIndividualLine(new Point(2, 0), new Point(-1, 1), player);

			foreach (bool playerWon in lineWon)
			{
				if (playerWon)
				{
					return true;
				}
			}

			return false;
		}

		private static bool CheckIndividualLine(Point index, Point incrementation, char player)
		{
			int filledCells = 0;

			for (int i = 0; i < 3; i++)
			{
				if (_board[index.X, index.Y] == player)
				{
					filledCells++;
				}

				index.X += incrementation.X;
				index.Y += incrementation.Y;
			}

			return filledCells == 3;
		}

		private static void WriteWinnner()
		{
			if (_currentTurn < 8)
				Console.WriteLine($"' {currentPlayer} ' wins");
			else
				Console.WriteLine($"The game is draw");
		}
	}
}
