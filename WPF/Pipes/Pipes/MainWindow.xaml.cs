using Pipes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pipes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PipesGrid pipesGrid;

        public MainWindow()
        {
            InitializeComponent();

            var pipes = new List<Pipe>();
            pipes.Add(new CranePipe(0, 0, this));
            pipes.Add(new StraightPipe(0, 1, this));
            pipes.Add(new TurnPipe(0, 2, this));
            pipes.Add(new TurnPipe(1, 2, this));
            pipes.Add(new StraightPipe(1, 1, this));
            pipes.Add(new TurnPipe(1, 0, this));
            pipes.Add(new StraightPipe(2, 0, this));
            pipes.Add(new StraightPipe(3, 0, this));
            pipes.Add(new StraightPipe(4, 0, this));
            pipes.Add(new TurnPipe(5, 0, this));
            pipes.Add(new StraightPipe(5, 1, this));
            pipes.Add(new TurnPipe(5, 2, this));
            pipes.Add(new StraightPipe(4, 2, this));
            pipes.Add(new StraightPipe(3, 2, this));
            pipes.Add(new TurnPipe(2, 2, this));
            pipes.Add(new TurnPipe(2, 3, this));
            pipes.Add(new StraightPipe(1, 3, this));
            pipes.Add(new TurnPipe(0, 3, this));
            pipes.Add(new StraightPipe(0, 4, this));
            pipes.Add(new TurnPipe(0, 5, this));
            pipes.Add(new StraightPipe(1, 5, this));
            pipes.Add(new StraightPipe(2, 5, this));
            pipes.Add(new StraightPipe(3, 5, this));
            pipes.Add(new TurnPipe(4, 5, this));
            pipes.Add(new TurnPipe(4, 4, this));
            pipes.Add(new TurnPipe(5, 4, this));

            var downPipe = new DownPipe(5, 5, this);
                //downPipe.RotateNTimes(3);
            pipes.Add(downPipe);

            pipesGrid = new PipesGrid();
            pipesGrid.SpawnGrid(this, pipes);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (PipesWindow.Width > PipesWindow.Height)
            {
                PipesGrid.Width = PipesWindow.Height - 50;
                PipesGrid.Height = PipesWindow.Height - 50;
            }
            else
            {
                PipesGrid.Width = PipesWindow.Width - 50;
                PipesGrid.Height = PipesWindow.Width -50;
            }
        }

        private void Pipe_Click(object sender, RoutedEventArgs e)
        {
            pipesGrid.HandlePipeClick(sender);
        }

        private void Crane_Click(object sender, RoutedEventArgs e)
        {
            pipesGrid.HandleCraneClick();
        }
    }
}
