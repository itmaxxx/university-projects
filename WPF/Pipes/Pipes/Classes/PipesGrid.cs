using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pipes.Classes
{
    enum PipesSidesName : int
    {
        Top,
        Right,
        Bottom,
        Left
    }

    public class PipesGrid
    {
        public List<Pipe> Pipes { get; private set; }
        private bool isBusy = false;

        public PipesGrid()
        {
            Pipes = new List<Pipe>();
        }

        public void SpawnGrid(MainWindow window, List<Pipe> pipes)
        {
            Pipes = pipes;

            foreach (var pipe in pipes)
            {
                window.PipesGrid.Children.Add(pipe.Button);
            }

            for (int i = 1; i < pipes.Count - 1; i++)
            {
                for (int a = 0; a < new Random().Next(0, 4); a++)
                {
                    pipes[i].Rotate();
                }

                //MessageBox.Show(pipes[i].Angle.ToString());
            }

            for (int x = 0; x < window.PipesGrid.ColumnDefinitions.Count; x++)
            {
                for (int y = 0; y < window.PipesGrid.RowDefinitions.Count; y++)
                {
                    var pipe = Pipes.Find(pipe => pipe.X == x && pipe.Y == y);

                    if (pipe == null)
                    {
                        var emptyBtn = new Button();

                        Grid.SetColumn(emptyBtn, x);
                        Grid.SetRow(emptyBtn, y);

                        emptyBtn.Style = window.FindResource("Empty") as Style;

                        window.PipesGrid.Children.Add(emptyBtn);
                    }
                }
            }
        }

        private bool TryToFindPipe(int x, int y, bool water, PipesSidesName fromSide)
        {
            Pipe pipe = Pipes.Find(e => e.X == x && e.Y == y);

            if (pipe != null)
            {
                if (fromSide == PipesSidesName.Top && pipe.Sides.Bottom)
                {
                    //MessageBox.Show("Top to Bottom");

                    pipe.SetWater(water);

                    return true;
                }

                if (fromSide == PipesSidesName.Right && pipe.Sides.Left)
                {
                    //MessageBox.Show("Right to Left");

                    pipe.SetWater(water);

                    return true;
                }

                if (fromSide == PipesSidesName.Bottom && pipe.Sides.Top)
                {
                    //MessageBox.Show("Bottom to Top");

                    pipe.SetWater(water);
                 
                    return true;
                }

                if (fromSide == PipesSidesName.Left && pipe.Sides.Right)
                {
                    //MessageBox.Show("Left to Right");

                    pipe.SetWater(water);
                 
                    return true;
                }
            }

            return false;
        }

        public void HandlePipeClick(object sender)
        {
            if (isBusy)
            {
                return;
            }

            var button = (Button)sender;

            Grid.GetColumn(button);
            Grid.GetRow(button);

            var pipe = Pipes.Find(e => e.X == Grid.GetColumn(button) && e.Y == Grid.GetRow(button));

            pipe.HandleClick();
        }

        public void HandleCraneClick()
        {
            if (!isBusy)
            {
                Pipes[0].HandleClick();

                var task = new Task(() => TryStartWater());

                task.Start();
            }
        }

        private void DryAllPipes()
        {
            foreach (var pipe in Pipes)
            {
                pipe.SetWater(false);
            }
        }

        public void TryStartWater()
        {
            isBusy = true;

            DryAllPipes();

            Pipes[0].SetWater(true);

            foreach (var pipe in Pipes)
            {
                bool found = false;

                if (pipe.Water)
                {
                    if (pipe.Sides.Top)
                    {
                        if (TryToFindPipe(pipe.X, pipe.Y - 1, true, PipesSidesName.Top))
                        {
                            found = true;
                        }
                    }
                    if (pipe.Sides.Right)
                    {
                        if (TryToFindPipe(pipe.X + 1, pipe.Y, true, PipesSidesName.Right))
                        {
                            found = true;
                        }
                    }
                    if (pipe.Sides.Bottom)
                    {
                        if (TryToFindPipe(pipe.X, pipe.Y + 1, true, PipesSidesName.Bottom))
                        {
                            found = true;
                        }
                    }
                    if (pipe.Sides.Left)
                    {
                        if (TryToFindPipe(pipe.X - 1, pipe.Y, true, PipesSidesName.Left))
                        {
                            found = true;
                        }
                    }
                }

                //MessageBox.Show($"{found} {pipe.X} {pipe.Y}");

                if (!found)
                {
                    break;
                }

                Thread.Sleep(250);
            }

            if (Pipes[Pipes.Count - 1].Water)
            {
                MessageBox.Show("Вы победили!");

                return;
            }

            // Remove water if didn't win

            Pipes[0].SetWater(false);

            foreach (var pipe in Pipes)
            {
                bool found = false;

                if (!pipe.Water)
                {
                    if (pipe.Sides.Top)
                    {
                        if (TryToFindPipe(pipe.X, pipe.Y - 1, false, PipesSidesName.Top))
                        {
                            found = true;
                        }
                    }
                    if (pipe.Sides.Right)
                    {
                        if (TryToFindPipe(pipe.X + 1, pipe.Y, false, PipesSidesName.Right))
                        {
                            found = true;
                        }
                    }
                    if (pipe.Sides.Bottom)
                    {
                        if (TryToFindPipe(pipe.X, pipe.Y + 1, false, PipesSidesName.Bottom))
                        {
                            found = true;
                        }
                    }
                    if (pipe.Sides.Left)
                    {
                        if (TryToFindPipe(pipe.X - 1, pipe.Y, false, PipesSidesName.Left))
                        {
                            found = true;
                        }
                    }
                }

                //MessageBox.Show($"{found} {pipe.X} {pipe.Y}");

                if (!found)
                {
                    break;
                }

                Thread.Sleep(250);
            }

            isBusy = false;
        }
    }
}
