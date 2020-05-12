using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMatrix
{
	class Program
	{
		static Random RANDOM = new Random();
		static int CONSOLE_WIDTH = 120;
		static int CONSOLE_HEIGHT = 30;

		class Position
		{
			public int X { get; set; }
			public int Y { get; set; }

			public Position()
			{
				X = 0;
				Y = 0;
			}

			public Position(int x, int y)
			{
				X = x;
				Y = y;
			}

			public bool Equals(Position position)
			{
				if (position.X == X && position.Y == Y)
					return true;
				else
					return false;
			}
		}

		class Symbol
		{
			private char _symbol;
			private byte _color;

			public Symbol(int num)
			{
				PickSymbol();

				if (num == 0)
					_color = (byte)ConsoleColor.White;
				else if (num == 1)
					_color = (byte)ConsoleColor.Green;
				else
					_color = (byte)ConsoleColor.DarkGreen;
			}

			public void PickSymbol()
			{
				_symbol = (char)RANDOM.Next(0, 255);
			}

			public char GetSymbol()
			{
				return _symbol;
			}

			public byte GetColor()
			{
				return _color;
			}
		}

		class Chain
		{
			private List<Symbol> _symbols;
			private Position _position; // "Head" element position
			private bool _alive;

			public Chain()
			{
				_symbols = new List<Symbol>();
				_alive = true;

				GenerateRandomPosition();
				GenerateSymbols();
			}

			public void GenerateRandomPosition()
			{
				_position = new Position(RANDOM.Next(0, CONSOLE_WIDTH), 0);
			}

			public void SetAlive(bool alive)
			{
				_alive = alive;
			}

			public bool GetAlive()
			{
				return _alive;
			}

			public void SetPosition(Position position)
			{
				_position = position;
			}

			private void GenerateSymbols()
			{
				for (int i = 0; i < RANDOM.Next(4, 10); i++)
				{
					_symbols.Add(new Symbol(i));
				}
			}

			private void RandomSymbols()
			{
				for (int i = 0; i < _symbols.Count; i++)
				{
					_symbols[i].PickSymbol();
				}
			}

			private void Clear()
			{
				if (_position.Y - (_symbols.Count - 1) >= 0)
				{
					Console.SetCursorPosition(_position.X, _position.Y - (_symbols.Count - 1));
					Console.Write(" ");
				}
			}

			private void Print()
			{
				for (int i = 0; i < _symbols.Count - 1; i++)
				{
					if (_position.Y - i >= 0 && _position.Y <= CONSOLE_HEIGHT - 4)
					{	
						Console.SetCursorPosition(_position.X, _position.Y - i);
						Console.ForegroundColor = (System.ConsoleColor)_symbols.ElementAt(i).GetColor();
						Console.Write(_symbols.ElementAt(i).GetSymbol());
						Console.ResetColor();
					}
				}
			}

			public void Move()
			{
				_position.Y++;
				Clear();
				RandomSymbols();
				Print();
			}

			public void Respawn()
			{
				GenerateRandomPosition();
				_alive = true;
			}

			public int GetTailYCoord()
			{
				return _position.Y - _symbols.Count;
			}

			public Position GetPosition()
			{
				return _position;
			}

			public bool CheckIfOutOfField()
			{
				if (GetTailYCoord() >= CONSOLE_HEIGHT - _symbols.Count)
					return true;
				else
					return false;
			}
		}

		class MatrixThread
		{
			private Thread thread;
			private Chain chain;
			private int pauseTime;

			public MatrixThread()
			{
				thread = new Thread(new ThreadStart(Process));
				chain = new Chain();

				pauseTime = RANDOM.Next(200, 500);

				thread.IsBackground = false;
				thread.Start();
			}

			private void Process()
			{
				while(true)
				{
					lock (this)
					{
						if (chain.CheckIfOutOfField())
							chain.SetAlive(false);

						if (chain.GetAlive())
							chain.Move();
						else
							chain.Respawn();

						Thread.Sleep(pauseTime);
					}
				}
			}
		}

		class Matrix
		{
			private List<MatrixThread> threads;

			public Matrix(int count)
			{
				threads = new List<MatrixThread>();

				for (int i = 0; i < count; i++)
				{
					threads.Add(new MatrixThread());
				}
			}
		}

		static void Main(string[] args)
		{
			//                        |
			//                        |    тут ставим количество потоков
			//                        \/
			Matrix matrix = new Matrix(1);
		}
	}
}
