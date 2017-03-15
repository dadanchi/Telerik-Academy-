namespace Minesweeper.Core
{
    using System;
    using System.Collections.Generic;

    using Minesweeper.Models;

    public static class Engine
    {
        public static void ExecuteCommand()
        {
            const int MaxPoints = 35;

            var newLine = Environment.NewLine;
            string command = string.Empty;
            char[,] field = CreatePlayField();
            char[,] bombs = SetTheBombs();
            int playerPoints = 0;
            bool isShot = false;
            var champions = new List<Point>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            bool gameIsWon = false;

            do
            {
                if (isNewGame)
                {
                    IntroduceGame();
                    PrintBoard(field);
                    isNewGame = false;
                }

                Console.Write("Choose a row and a cow : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "ScoreBoard":
                        ListScoreBoard(champions);
                        break;
                    case "Restart":
                        field = CreatePlayField();
                        bombs = SetTheBombs();
                        PrintBoard(field);
                        isShot = false;
                        isNewGame = false;
                        break;
                    case "Exit":
                        Console.WriteLine("GoodBye :)");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                GetNextTurn(field, bombs, row, col);
                                playerPoints++;
                            }

                            if (MaxPoints == playerPoints)
                            {
                                gameIsWon = true;
                            }
                            else
                            {
                                PrintBoard(field);
                            }
                        }
                        else
                        {
                            isShot = true;
                        }

                        break;
                    default:
                        Console.WriteLine(newLine + "Invalid Command" + newLine);
                        break;
                }

                if (isShot)
                {
                    var dieMessage = $"Hrrrrrr! You died with {playerPoints} points.";

                    PrintBoard(bombs);
                    Console.Write(newLine + dieMessage + newLine);
                    Console.WriteLine("Please, enter your nickname: ");

                    string nickName = Console.ReadLine();
                    Point playerFinalPoints = new Point(nickName, playerPoints);

                    if (champions.Count < 5)
                    {
                        champions.Add(playerFinalPoints);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < playerFinalPoints.Points)
                            {
                                champions.Insert(i, playerFinalPoints);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Point r1, Point r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Point r1, Point r2) => r2.Points.CompareTo(r1.Points));
                    ListScoreBoard(champions);

                    field = CreatePlayField();
                    bombs = SetTheBombs();
                    playerPoints = 0;
                    isShot = false;
                    isNewGame = true;
                }

                if (gameIsWon)
                {
                    var winMessage = $"Excellent! You opened all {MaxPoints} cells without hitting a bomb!";

                    Console.WriteLine(newLine + winMessage + newLine);
                    PrintBoard(bombs);
                    Console.WriteLine("Please, give write your nickname: ");

                    string playerName = Console.ReadLine();
                    Point points = new Point(playerName, playerPoints);

                    champions.Add(points);
                    ListScoreBoard(champions);
                    field = CreatePlayField();
                    bombs = SetTheBombs();
                    playerPoints = 0;
                    gameIsWon = false;
                    isNewGame = true;
                }
            }
            while (command != "Exit");
        }

        private static void IntroduceGame()
        {
            const string StartMessage = @"Lets play ""Mines"". Try your luck to find the fields without mines.";
            const string IntroduceCommands = "There are several commands: ";

            var commands = new List<string>
            {
                "\"ScoreBoard\" for the bes results",
                "\"Restart\" for a new game",
                "\"Exit\" to leave the game."
            };

            Console.WriteLine(StartMessage);
            Console.WriteLine(IntroduceCommands);
            Console.WriteLine();

            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
        }

        private static void ListScoreBoard(List<Point> points)
        {
            if (points.Count > 0)
            {
                Console.WriteLine("ScoreBoard: ");

                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Scoreboard" + Environment.NewLine);
            }
        }

        private static void GetNextTurn(char[,] board, char[,] bombs, int row, int col)
        {
            char bombsCount = GetSurroundingBombsCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            board[row, col] = bombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < boardRows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < boardColumns; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] SetTheBombs()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '-';
                }
            }

            var randomNumbers = new List<int>();

            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int nextRandomNumber = random.Next(50);

                if (!randomNumbers.Contains(nextRandomNumber))
                {
                    randomNumbers.Add(nextRandomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int col = number / boardColumns;
                int row = number % boardColumns;

                if (row == 0 && number != 0)
                {
                    col--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void FillTheBoardWithProperBombCounters(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    if (board[row, col] != '*')
                    {
                        char surroundingBombs = GetSurroundingBombsCount(board, row, col);
                        board[row, col] = surroundingBombs;
                    }
                }
            }
        }

        private static char GetSurroundingBombsCount(char[,] board, int row, int col)
        {
            int surroundingBombsCount = 0;
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if (row + 1 < boardRows)
            {
                if (board[row + 1, col] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if (col + 1 < boardColumns)
            {
                if (board[row, col + 1] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < boardColumns))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if ((row + 1 < boardRows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            if ((row + 1 < boardRows) && (col + 1 < boardColumns))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    surroundingBombsCount++;
                }
            }

            return char.Parse(surroundingBombsCount.ToString());
        }
    }
}
