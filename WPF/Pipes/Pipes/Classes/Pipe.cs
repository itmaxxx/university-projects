using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Net.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Pipes.Classes
{
    public class PipeSides
    {
        public bool Top { get; set; }
        public bool Right { get; set; }
        public bool Bottom { get; set; }
        public bool Left { get; set; }

        public PipeSides()
        {
            SetSides(false, false, false, false);
        }

        public PipeSides(bool top, bool right, bool bottom, bool left)
        {
            SetSides(top, right, bottom, left);
        }

        private void SetSides(bool top, bool right, bool bottom, bool left)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }

        public void Rotate()
        {
            bool rememberTop = Top, rememberRight = Right, rememberBottom = Bottom;

            Top = Left;
            Right = rememberTop;
            Bottom = rememberRight;
            Left = rememberBottom;
        }
    }

    public abstract class Pipe
    {
        public int Angle { get; protected set; }
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public bool Water { get; protected set; }
        public Button Button { get; protected set; }
        public PipeSides Sides { get; protected set; }
        protected MainWindow window;

        public Pipe(int x, int y, MainWindow window)
        {
            Angle = 0;
            X = x;
            Y = y;
            Water = false;
            Button = new Button();
            Sides = new PipeSides();
            this.window = window;
        }

        public void Rotate(int angle)
        {
            Angle = angle % 360;

            RotateTransform rotateTransform = Button.RenderTransform as RotateTransform;

            if (rotateTransform != null)
            {
                Button.RenderTransform = new RotateTransform(Angle);

            }
        }

        public void Rotate()
        {
            Rotate(Angle + 90);

            Sides.Rotate();

            //MessageBox.Show($"     {Sides.Top}\n{Sides.Left}   {Sides.Right}\n     {Sides.Bottom}");
        }

        public void RotateNTimes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Rotate();
            }
        }

        protected abstract void SetWaterStyle();

        public void SetWater(bool water)
        {
            Water = water;

            SetWaterStyle();
        }

        public abstract void HandleClick();
    }

    public class StraightPipe : Pipe
    {
        public StraightPipe(int x, int y, MainWindow window) : base(x, y, window)
        {
            Button.Style = this.window.FindResource("StraightPipeEmpty") as Style;

            Grid.SetColumn(Button, X);
            Grid.SetRow(Button, Y);

            Sides = new PipeSides(true, false, true, false);
        }

        protected override void SetWaterStyle()
        {
            if (Water)
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("StraightPipeWithWater") as Style;
                });
            }
            else
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("StraightPipeEmpty") as Style;
                });
            }
        }

        public override void HandleClick()
        {
            Rotate();
        }
    }

    public class TurnPipe : Pipe
    {
        public TurnPipe(int x, int y, MainWindow window) : base(x, y, window)
        {
            Button.Style = this.window.FindResource("TurnPipeEmpty") as Style;

            Grid.SetColumn(Button, X);
            Grid.SetRow(Button, Y);

            Sides = new PipeSides(false, true, true, false);
        }

        protected override void SetWaterStyle()
        {
            if (Water)
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("TurnPipeWithWater") as Style;
                });
            }
            else
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("TurnPipeEmpty") as Style;
                });
            }
        }

        public override void HandleClick()
        {
            Rotate();
        }
    }

    public class CranePipe : Pipe
    {
        public CranePipe(int x, int y, MainWindow window) : base(x, y, window)
        {
            Button.Style = this.window.FindResource("CranePipeEmpty") as Style;

            Grid.SetColumn(Button, X);
            Grid.SetRow(Button, Y);

            Sides = new PipeSides(false, false, true, false);
        }

        protected override void SetWaterStyle()
        {
            if (Water)
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("CranePipeWithWater") as Style;
                });
            }
            else
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("CranePipeEmpty") as Style;
                });
            }
        }

        public override void HandleClick()
        {
            SetWater(true);
        }
    }

    public class DownPipe : Pipe
    {
        public DownPipe(int x, int y, MainWindow window) : base(x, y, window)
        {
            Button.Style = this.window.FindResource("DownPipeFinish") as Style;

            Grid.SetColumn(Button, X);
            Grid.SetRow(Button, Y);

            Sides = new PipeSides(true, false, false, false);
        }

        protected override void SetWaterStyle()
        {
            if (Water)
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("DownPipeWithWater") as Style;
                });
            }
            else
            {
                window.Dispatcher.Invoke(() =>
                {
                    Button.Style = window.FindResource("DownPipeFinish") as Style;
                });
            }
        }

        public override void HandleClick()
        {
            throw new NotImplementedException();
        }
    }
}
