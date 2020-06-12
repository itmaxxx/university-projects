using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battle
{
    class Program
    {
        private static Random random = new Random();
        private static object lockObj = new object();
        private const int maxUnitsRespawned = 10;

        public class Team
        {
            private Team enemy;
            private ConsoleColor color;

            public Thread GetThread { get; set; }
            public int Count;

            public Team(ConsoleColor color, int count)
            {
                this.color = color;
                Count = count;
            }

            public void SetEnemy(Team team)
            {
                enemy = team;
            }

            public void Fight()
            {
                while (Count > 0)
                {
                    lock (lockObj)
                    {
                        Console.ForegroundColor = color;

                        int killed = random.Next(0, Count);
                        enemy.Count -= killed;
                        Console.WriteLine($"убили {killed} бойцов врага");
                        Thread.Sleep(random.Next(300, 900));

                        int dead = random.Next(0, killed);
                        Count -= dead;
                        Console.WriteLine($"умерло {dead} наших бойцов");
                        Thread.Sleep(random.Next(300, 900));

                        int respawned = random.Next(0, maxUnitsRespawned);
                        Count += respawned;
                        Console.WriteLine($"{respawned} бойцов было добавлено в команду");

                        if (Count < 0)
                        {
                            Count = 0;
                        }
                    }

                    Thread.Sleep(random.Next(300, 900));
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-= Итоговая Статистика =-");

                Console.ForegroundColor = color;
                Console.WriteLine($"{Count} бойцов выжило");

                Console.ForegroundColor = enemy.color;
                Console.WriteLine($"{enemy.Count} бойцов осталось");

                enemy.GetThread.Abort();
                GetThread.Abort();
            }
        }

        public class Battle
        {
            Team firstTeam = new Team(ConsoleColor.Green, 15);
            Team secondTeam = new Team(ConsoleColor.Yellow, 15);

            public void Start()
            {
                Console.WriteLine("-= Битва Начинается =-");

                firstTeam.SetEnemy(secondTeam);
                firstTeam.GetThread = new Thread(new ThreadStart(firstTeam.Fight));
                firstTeam.GetThread.Start();

                secondTeam.SetEnemy(firstTeam);
                secondTeam.GetThread = new Thread(new ThreadStart(secondTeam.Fight));
                secondTeam.GetThread.Start();
            }
        }

        static void Main(string[] args)
        {
            Battle battle = new Battle();
            battle.Start();
        }
    }
}
