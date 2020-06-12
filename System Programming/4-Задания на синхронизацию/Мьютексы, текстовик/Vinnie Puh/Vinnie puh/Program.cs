using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Vinnie_puh
{
    class Program
    {
        private static Random random = new Random();
        private static object lockObj = new object();

        private static int beesCount = 9,
                           beeGatherTimeMin = 500,
                           beeGatherTimeMax = 1500,
                           beeGather = 1;

        private static int puhEats = 50,
                           puhSleeps = 5000;

        private static int honey = 0;
        private static bool gameOver = false;

        class Bee
        {
            private Thread thread;
            private int gatherTime;
            private int id;

            public Bee(int id)
            {
                thread = new Thread(new ThreadStart(Gather));
                thread.Start();

                gatherTime = random.Next(beeGatherTimeMin, beeGatherTimeMax);

                this.id = id;
            }

            public void Gather()
            {
                while (!gameOver)
                {
                    lock (lockObj)
                    {
                        honey += beeGather;

                        Console.WriteLine($"bee #{id} gathered honey (total honey : {honey})");
                    }

                    Thread.Sleep(gatherTime);
                }
            }
        }

        class VinniePuh
        {
            private Thread thread;
            private bool starving;

            public VinniePuh()
            {
                thread = new Thread(new ThreadStart(Eat));
                thread.Start();

                starving = false;
            }

            public void Eat()
            {
                while (true)
                {
                    lock (lockObj)
                    {
                        if (honey >= puhEats)
                        {
                            honey -= puhEats;

                            Console.WriteLine($"Vinnie Puh eats {puhEats} honey");

                            starving = false;
                        }
                        else if (starving)
                        {
                            Console.WriteLine($"Vinnie Puh was unable to eat, game over");

                            gameOver = true;

                            return;
                        }
                        else
                        {
                            starving = true;

                            Console.WriteLine($"Vinnie Puh was unable to eat, starving started");
                        }
                    }

                    Thread.Sleep(puhSleeps);
                }
            }
        }

        static void Main(string[] args)
        {
            List<Bee> bees = new List<Bee>();

            for (int i = 0; i < beesCount; i++)
            {
                bees.Add(new Bee(i + 1));
            }

            VinniePuh vinniePuh = new VinniePuh();
        }
    }
}
