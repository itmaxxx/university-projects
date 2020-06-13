using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scout
{
    class Program
    {
        private static Random random = new Random();
        private static Stopwatch stopwatch = new Stopwatch();
        private static object lockObj = new object();

        private const int matrixWidth = 10;
        private const int matrixHeight = 10;

        public class Matrix
        {
            private const int seekersCount = 5;
            private char[,] matrix;

            public Seeker[] Seekers { get; private set; }

            public Matrix()
            {
                Seekers = new Seeker[seekersCount];

                for (int i = 0; i < Seekers.Count(); i++)
                {
                    Seekers[i] = new Seeker();
                }

                matrix = new char[matrixWidth, matrixHeight];

                Fill();
                Start();
            }

            private char GetFieldChar()
            {
                return (random.Next(0, 2) == 0 ? '0' : '1' );
            }

            private void Fill()
            {
                for (int i = 0; i < matrixHeight; i++)
                {
                    for (int j = 0; j < matrixWidth; j++)
                    {
                        matrix[i, j] = GetFieldChar();
                    }
                }
            }

            private void Start()
            {
                stopwatch.Start();

                int num = 1;

                foreach (var seeker in Seekers)
                {
                    seeker.SeekerThread = new Thread(new ParameterizedThreadStart(seeker.Seek));
                    seeker.SeekerThread.Name = $"Seeker #{num}";
                    seeker.SeekerThread.Start(matrix);

                    num++;
                }
            }
        }

        public class Seeker
        {
            private static int seekTime = 3;
            private int x, y;
            private char symbol = 'X';

            public Thread SeekerThread;
            public int FoundCount { get; private set; } = 0;

            public Seeker()
            {
                x = random.Next(0, matrixWidth - 1);
                y = random.Next(0, matrixHeight - 1);
            }

            public void Move()
            {
                int direction = random.Next(1, 4);

                if (direction == 1 && y != 0)
                {
                    y--;
                }
                else if (direction == 2 && y != matrixHeight - 1)
                {
                    y++;
                }
                else if (direction == 3 && x != 0)
                {
                    x--;
                }
                else if (direction == 4 && x != matrixWidth - 1)
                {
                    x++;
                }
            }

            public void Seek(object matrix)
            {
                while (stopwatch.ElapsedMilliseconds <= seekTime * 1000)
                {
                    lock (lockObj)
                    {
                        char[,] _matrix = (char[,])matrix;

                        Move();

                        if (_matrix[x, y] == '1')
                        {
                            FoundCount++;
                        }

                        _matrix[x, y] = symbol;

                        Show(_matrix);
                    }

                    Thread.Sleep(random.Next(300, 500));
                }

                SeekerThread.Abort();
            }

            private void Show(char[,] matrix)
            {
                Console.Clear();

                for (int x = 0; x < matrixWidth; x++)
                {
                    Console.WriteLine();

                    for (int y = 0; y < matrixHeight; y++)
                    {
                        if (matrix[x, y] == 'X')
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                        Console.Write(matrix[x, y]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            Console.WriteLine("\n\n- - - - - - - - - - - - - - - -");

            foreach (var seeker in matrix.Seekers)
            {
                Console.WriteLine($"{seeker.SeekerThread.Name} - {seeker.FoundCount}");
            }
        }
    }
}