using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Program
    {
        private static int _boardSize = 0;
        private static int _lineSize = 0;
        private static char[,] _board;
        private static int _currentTurn = 0;
        private static char currentPlayer;

        private static void Main(string[] args)
        {
            GetBoardStats();
            InitBoard();
            DisplayBoard();

            bool gameOver = false;

            while(!gameOver)
            {
                GetPlayerMove();
                gameOver = CheckResult();
                DisplayBoard();
            }
            
            GetWinnner();
        }

        private static void GetBoardStats()
        {
            while(_boardSize < 3 || _lineSize < 3 || _lineSize > _boardSize)
            {
                Console.WriteLine($"Choose board and line size");
                
                string input = Console.ReadLine();
                string[] symbols = input.Split(' ');

                if(symbols.Length >= 2)
                {
                    if (int.TryParse(symbols[0], out _boardSize) && int.TryParse(symbols[1], out _lineSize))
                    {
                        if(_boardSize < 3 || _lineSize < 3 || _lineSize > _boardSize)
                        {
                            Console.WriteLine("The parameters be of appropriate size");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private static void InitBoard()
        {
            _board = new char[_boardSize, _boardSize];

            for (var r = 0; r < _boardSize; r++)
            {
                for (var c = 0; c < _boardSize; c++)
                    _board[r, c] = ' ';
            }
        }

        private static void GetPlayerMove()
        {
            currentPlayer = GetPlayerSymbol(_currentTurn);

            Console.WriteLine($"' {currentPlayer} ', choose your location (row, column): ");

            string input = Console.ReadLine();

            string[] symbols = input.Split(' ');

            if (symbols.Length < 2) Console.WriteLine("The location consists of two numbers");

            if (int.TryParse(symbols[0], out int loc1) && int.TryParse(symbols[1], out int loc2))
            {
                if(loc1 < 0 && loc2 < 0 && loc1 >= _boardSize && loc2 >= _boardSize)
                {
                    Console.WriteLine("The location must fit in board margins");
                    return;
                }
                if(_board[loc1, loc2] == ' ')
                {
                    _board[loc1, loc2] = currentPlayer;
                    _currentTurn++;
                    return;
                }
                Console.WriteLine("You must give a new location");
            }

            Console.WriteLine("Enter two numbers.");
        }

        private static char GetPlayerSymbol(int currentTurn)
        {
            return currentTurn % 2 == 0? 'X' : 'O';
        }

        private static bool CheckResult()
        {
            if(_currentTurn < 5) return false;

            bool firstPlayer = GetIndividualResult('X');
            bool secondPlayer = GetIndividualResult('O');

            return firstPlayer || secondPlayer;
        }

        private static bool GetIndividualResult(char player)
        {
            List<(int, int)> indexes = new List<(int, int)>();

            for(int row = 0; row < _boardSize; row++)
            {
                for(int col = 0; col < _boardSize; col++)
                {
                    if(_board[row, col] == player)
                        indexes.Add((row, col));
                }
            }

            if(indexes.Count < _lineSize) 
                return false;

            int xDiff = indexes[1].Item1 - indexes[0].Item1;
            int yDiff = indexes[1].Item2 - indexes[0].Item2;

            int reps = 0;
            int repsNeedToWin = _lineSize - 2;
            
            for(int i = 2; i < indexes.Count; i++)
            {
                int curxDiff = indexes[i].Item1 - indexes[i - 1].Item1;
                int curyDiff = indexes[i].Item2 - indexes[i - 1].Item2;

                if(xDiff != curxDiff || yDiff != curyDiff)
                {
                    xDiff = curxDiff;
                    yDiff = curyDiff;
                    reps = 0;
                }
                else
                    reps++;
            }

            return reps == repsNeedToWin;
        }

        private static void GetWinnner()
        {
            if(_currentTurn < _boardSize * _boardSize)
                Console.WriteLine($"' {currentPlayer} ' wins");
            else
                Console.WriteLine($"The game is draw");
        }

        private static void DisplayBoard()
        {
            StringBuilder builder = new StringBuilder();

            for(int i = 0; i < _boardSize; i++)
                builder.Append("--+");

            string underline = builder.ToString();
            
            for(int row = 0; row < _boardSize; row++)
            {
                builder = new StringBuilder();
                builder.Append($"  {row}  ");

                for(int col = 0; col < _boardSize; col++)
                {
                    builder.Append(_board[row, col]);
                    builder.Append("|");
                }
                builder.Remove(builder.Length - 1, 1);

                string upperLine = builder.ToString();

                Console.WriteLine(upperLine);
                Console.WriteLine(underline);
            }
        }
    }
}
