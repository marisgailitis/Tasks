using System;
using System.Collections.Generic;
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
            SetBoardStats();
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

        private static void SetBoardStats()
        {
            //no point in having either 2x2 board or a line of 2 points required to win
            while(_boardSize < 3 || _lineSize < 3 || _lineSize > _boardSize)
            {
                Console.WriteLine($"Choose board and line size");
                
                string input = Console.ReadLine();
                string[] symbols = input.Split(' ');
                bool sufficientInput = symbols.Length >= 2;

                if(sufficientInput)
                {
                    if (int.TryParse(symbols[0], out _boardSize) && int.TryParse(symbols[1], out _lineSize))
                    {
                        bool boardTooSmall = _boardSize < 3 || _lineSize < 3;
                        bool lineOutOfBounds = _lineSize > _boardSize;

                        if(boardTooSmall || lineOutOfBounds)
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

            Console.WriteLine($"' {currentPlayer} ', choose your coordinates (row, column): ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            if (numbers.Length < 2) Console.WriteLine("The cell coordinates consist of two parameters");

            if (int.TryParse(numbers[0], out int row) && int.TryParse(numbers[1], out int col))
            {
                if(row < 0 || col < 0 || row >= _boardSize || col >= _boardSize)
                {
                    Console.WriteLine("The cell must fit in board margins");
                    return;
                }
                //if the cell is free, fill it
                if(_board[row, col] == ' ')
                {
                    _board[row, col] = currentPlayer;
                    _currentTurn++;
                    return;
                }
                Console.WriteLine("Input a cell that is not taken");
            }

            Console.WriteLine("Could not get the coordinates from the input");
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
            // find the cells occupied by player
            List<BoardCoordinates> filledCells = new List<BoardCoordinates>();

            for(int x = 0; x < _boardSize; x++)
            {
                for(int y = 0; y < _boardSize; y++)
                {
                    if(_board[x, y] == player)
                        filledCells.Add(new BoardCoordinates(x, y));
                }
            }

            // too few moves done, no need to calculate further
            if(filledCells.Count < _lineSize) 
                return false;

            // set the first difference in direction for later reference
            int xDiff = filledCells[1].row - filledCells[0].row;
            int yDiff = filledCells[1].column - filledCells[0].column;

            int score = 0;
            int scoreNeedToWin = _lineSize - 2;

            //check if the reference matches constantly or it needs to be changed at some point
            //which means the line currently is not straight
            for(int i = 2; i < filledCells.Count; i++)
            {
                int new_x_Diff = filledCells[i].row - filledCells[i - 1].row;
                int new_y_Diff = filledCells[i].column - filledCells[i - 1].column;

                if(xDiff != new_x_Diff || yDiff != new_y_Diff)
                {
                    xDiff = new_x_Diff;
                    yDiff = new_y_Diff;
                    score = 0;
                }
                else
                    score++;
            }

            return score == scoreNeedToWin;
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
                builder.Append($" {row} ");

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

        public struct BoardCoordinates
        {
            public BoardCoordinates (int x_, int y_)
            {
                x = x_;
                y = y_;
            }

            public int x;
            public int y;
        }
    }
}
