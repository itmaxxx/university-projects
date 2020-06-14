using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class BoardCommand : ICommand
    {
		private Board board;
		private int x, y;

		public BoardCommand(int x, int y, Board board)
		{
			this.x = x;
			this.y = y;
			this.board = board;
		}

		public void Execute()
		{
			board.BoardMatrix[x, y] = board.CurrentPlayer;
			board.Update();
			board.SwitchPlayers();
		}

		public void Undo()
		{
			board.Undo();
		}
	}

	public class Board
	{
		private List<int[,]> boardStates = new List<int[,]>();

		public int CurrentPlayer;
		public bool Running { get; set; }
		public int[,] BoardMatrix { get; set; }

		public Board()
		{
			BoardMatrix = new int[3, 3]
			{
				{ 0, 0, 0},
				{ 0, 0, 0},
				{ 0, 0, 0},
			};

			boardStates.Add((int[,])BoardMatrix.Clone());

			Running = true;
			CurrentPlayer = 1;

			Update();
		}

		public bool Turn(int x, int y)
		{
			if (x > 2 || x < 0 || 
				y > 2 || y < 0)
			{
				return false;
			}

			if (BoardMatrix[x, y] == 0)
			{
				ICommand command = new BoardCommand(x, y, this);
				command.Execute();

				boardStates.Add((int[,])BoardMatrix.Clone());

				return true;
			}
			else
			{
				Update();

				return false;
			}
		}

		public void Undo()
		{
			if (boardStates.Count >= 2)
			{
				BoardMatrix = boardStates[boardStates.Count - 2];
				boardStates.RemoveAt(boardStates.Count - 1);
				Update();
			}
		}

		public void Update()
		{
			Console.Clear();

			Console.WriteLine($"Player {CurrentPlayer}");

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(BoardMatrix[i, j] + " ");
				}

				Console.WriteLine();
			}

			CheckWin();
		}

		public void SwitchPlayers()
		{
			if (CurrentPlayer == 1)
			{
				CurrentPlayer = 2;
			}
			else
			{
				CurrentPlayer = 1;
			}
		}

		public void CheckWin()
		{
			int val = 0;

			for (int i = 0; i < 3; i++)
			{
				if (BoardMatrix[i, val] == BoardMatrix[i, val + 1] && 
					BoardMatrix[i, val] == BoardMatrix[i, val + 2] && 
					BoardMatrix[i, val] != 0)
				{
					ShowWinner(BoardMatrix[i, val]);
				}

				if (BoardMatrix[val, i] == BoardMatrix[val + 1, i] && 
					BoardMatrix[val, i] == BoardMatrix[val + 2, i] && 
					BoardMatrix[val, i] != 0)
				{
					ShowWinner(BoardMatrix[i, val]);
				}
			}

			if (BoardMatrix[0, 0] == BoardMatrix[0 + 1, 0 + 1] && 
				BoardMatrix[0, 0] == BoardMatrix[0 + 2, 0 + 2] && 
				BoardMatrix[0, 0] != 0)
			{
				ShowWinner(BoardMatrix[0, 0]);
			}

			if (BoardMatrix[2, 2] == BoardMatrix[1, 1] && 
				BoardMatrix[0, 0] == BoardMatrix[0, 2] && 
				BoardMatrix[2, 2] != 0)
			{
				ShowWinner(BoardMatrix[2, 2]);
			}
		}

		public void ShowWinner(int Player)
		{
			Console.WriteLine($"Player {Player} won!");

			Running = false;
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			Board board = new Board();

			while (board.Running)
			{
				Console.WriteLine("U - Undo\nN - New turn");

				var key = Console.ReadKey();

				if (key.Key == ConsoleKey.N)
				{
					int x = 0, y = 0;

					while (!board.Turn(x, y))
					{
						Console.WriteLine("X : ");
						x = Convert.ToInt32(Console.ReadLine());

						Console.Write("Y : ");
						y = Convert.ToInt32(Console.ReadLine());
					}
				}
				else if (key.Key == ConsoleKey.U)
				{
					board.Undo();
				}
			}
		}
    }
}
