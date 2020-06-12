using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battle
{
    class Program
    {
        public static Random random = new Random();
        public static object lockObj = new object();
        public const int RESPAWN_MAX = 20;

        public class Team
        {
            public Thread thread;
            private Team enemy;
            private ConsoleColor color;
            public int count;

            public Team(ConsoleColor _color, int _count)
            {
                color = _color;
                count = _count;
            }

            public void SetEnemy(Team team)
            {
                enemy = team;
            }

            public void Fight()
            {
                while (count > 0)
                {
                    lock (lockObj)
                    {
                        Console.ForegroundColor = color;
                        int Killed = random.Next(0, this.count);
                        enemy.count -= Killed;
                        Console.WriteLine($"{Killed} воинов врага было убито");
                        Thread.Sleep(random.Next(300, 900));

                        int Died = random.Next(0, Killed);
                        this.count -= Died;
                        Console.WriteLine($"{Died} наших воинов было убито");
                        Thread.Sleep(random.Next(300, 900));

                        int Revived = random.Next(0, RESPAWN_MAX);
                        this.count += Revived;
                        Console.WriteLine($"{Revived} воинов добавилось в ряды сражений");
                    }
                    Thread.Sleep(random.Next(300, 900));
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("- - - - - - - - - - - - - - - - - -");

                Console.ForegroundColor = enemy.color;
                Console.WriteLine($"<!> {enemy.count}");

                Console.ForegroundColor = this.color;
                Console.WriteLine($"<!> {this.count}");


                enemy.thread.Abort();
                this.thread.Abort();
            }
        }

        public class Arena
        {
            Team teamRed = new Team(ConsoleColor.Red, 20);
            Team teamBlue = new Team(ConsoleColor.Blue, 20);

            public void Start()
            {
                teamBlue.SetEnemy(teamRed);
                teamBlue.thread = new Thread(new ThreadStart(teamBlue.Fight));
                teamBlue.thread.Start();

                teamRed.SetEnemy(teamBlue);
                teamRed.thread = new Thread(new ThreadStart(teamRed.Fight));
                teamRed.thread.Start();
            }
        }

        static void Main(string[] args)
        {
            Arena arena = new Arena();
            arena.Start();

            Console.ReadKey();
        }
    }
}
