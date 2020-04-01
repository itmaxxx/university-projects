using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TetrisFactory
{
	class Color
	{
		byte red;
		byte green;
		byte blue;

		public Color()
		{
			this.red = 0;
			this.green = 0;
			this.blue = 0;
		}

		public Color(byte red, byte green, byte blue)
		{
			SetColor(red, green, blue);
		}

		public void SetColor(byte red, byte green, byte blue)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
		}

		public byte GetRed()
		{
			return red;
		}

		public byte GetGreen()
		{
			return green;
		}

		public byte GetBlue()
		{
			return blue;
		}
	}

	abstract class Figure
	{
		protected bool[,] geometry;
		protected Color color;
		protected string name;

		public virtual void ShowInfo()
		{
			Console.WriteLine($"Name : {name}\nColor : r{color.GetRed()} g{color.GetGreen()} b{color.GetBlue()}");

			ShowFigure();
		}

		public void ShowFigure()
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (geometry[i,j])
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}

				Console.WriteLine();
			}
		}

		public static Figure CreateFigure(int type)
		{
			Figure figure = null;

			if (type == 1)
				figure = new Figure1();
			else if (type == 2)
				figure = new Figure2();
			else if (type == 3)
				figure = new Figure3();

			return figure;
		}
	}

	class Figure1 : Figure
	{
		public Figure1()
		{
			geometry = new bool[4, 4]
			{ 
				{ true, true, true, false }, 
				{ true, false, false, false }, 
				{ true, false, false, false }, 
				{ false, false, false, false }
			};
			color = new Color((byte) 0, (byte) 0, (byte) 0);
			name = "Figure 1";
		}
	}

	class Figure2 : Figure
	{
		public Figure2()
		{
			geometry = new bool[4, 4]
			{
				{ false, true, true, true },
				{ false, false, false, true },
				{ false, false, false, false },
				{ false, false, false, false }
			};
			color = new Color((byte) 255, (byte) 255, (byte) 255);
			name = "Figure 2";
		}
	}

	class Figure3 : Figure
	{
		public Figure3()
		{
			geometry = new bool[4, 4]
			{
				{ false, false, false, false },
				{ false, false, false, false },
				{ true, false, false, false },
				{ true, true, true, false }
			};
			color = new Color((byte) 121, (byte) 121, (byte) 121);
			name = "Figure 3";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Figure> figures = new List<Figure>();

			figures.Add(Figure.CreateFigure(1));
			figures.Add(Figure.CreateFigure(2));
			figures.Add(Figure.CreateFigure(3));

			for (int i = 0; i < figures.Count; i++)
			{
				figures.ElementAt(i).ShowInfo();
			}
		}
	}
}
