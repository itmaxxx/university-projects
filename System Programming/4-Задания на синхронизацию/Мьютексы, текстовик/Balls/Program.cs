using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Balls
{
    class Program
    {
        private static Random random = new Random();
        private static object locker = new object();
        private static int viewWidth = 40;
        private static int viewHeight = 40;

        class Coord
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Coord() : this(0, 0) {}

            public Coord(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        class Ball
        {
            public Thread thread;
            private Coord coord;
            private bool isAlive;
            private int id;
            private int sleepTime;

            public Ball(int id)
            {
                thread = new Thread(new ThreadStart(Move));
                coord = new Coord();
                this.id = id;

                Spawn();
                sleepTime = random.Next(200, 1000);

                Start();
            }


            private void Start()
            {
                thread.Start();
            }

            private void Spawn()
            {
                isAlive = true;

                coord = new Coord(random.Next(0, viewWidth), random.Next(0, viewHeight));

                Console.WriteLine($"ball {id} spawned at {coord.X}:{coord.Y}");
            }

            private void CheckIfOutOfView()
            {
                if (coord.X < 0 || 
                    coord.X > viewWidth ||
                    coord.Y < 0 ||
                    coord.Y > viewHeight)
                {
                    Console.WriteLine();

                    isAlive = false;

                    Spawn();
                }
            }

            public void Move()
            {
                while (true)
                {
                    lock (locker)
                    {
                        if (isAlive)
                        {
                            coord.X += random.Next(-1, 1);
                            coord.Y += random.Next(-1, 1);

                            Console.WriteLine($"new coords of ball {id} is {coord.X}:{coord.Y}");

                            CheckIfOutOfView();
                        }

                        Thread.Sleep(sleepTime);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            List<Ball> balls = new List<Ball>();

            balls.Add(new Ball(1));
            balls.Add(new Ball(2));
            balls.Add(new Ball(3));
            balls.Add(new Ball(4));
        }
    }
}
