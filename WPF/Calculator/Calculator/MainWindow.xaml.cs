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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char choosenOperation;
        private double result = 0;
        private double current = 0;

        public MainWindow()
        {
            InitializeComponent();

            resultLabel.Content = String.Empty;
        }

        // Logic

        private void EnterNumber(double number)
        {
            current = current == 0 ? number : double.Parse(current.ToString() + number.ToString());

            currentLabel.Content = current;
        }

        private void Sum()
		{
            if (choosenOperation == '+')
            {
                current = result + current;

                currentLabel.Content = current;

                result = 0;

                resultLabel.Content = String.Empty;
            }
            else if (choosenOperation == '-')
            {
                current = result - current;

                currentLabel.Content = current;

                result = 0;

                resultLabel.Content = String.Empty;
            }
            else if (choosenOperation == '*')
            {
                current = result * current;

                currentLabel.Content = current;

                result = 0;

                resultLabel.Content = String.Empty;
            }
            else if (choosenOperation == '/')
            {
                current = result / current;

                currentLabel.Content = current;

                result = 0;

                resultLabel.Content = String.Empty;
            }
        }

        // Cleaners

        private void Ce_Click(object sender, RoutedEventArgs e)
        {
            current = 0;
            currentLabel.Content = 0;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            result = 0;
            resultLabel.Content = 0;
            current = 0;
            currentLabel.Content = 0;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            current = current.ToString().Length <= 1 ? 0 : double.Parse(current.ToString().Substring(0, current.ToString().Length - 1));

            currentLabel.Content = current;
        }

        // Math operations

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Sum();

            choosenOperation = '/';

            result = current;

            resultLabel.Content = $"{result} ÷ ";

            current = 0;

            EnterNumber(0);
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            Sum();

            choosenOperation = '*';

            result = current;

            resultLabel.Content = $"{result} × ";

            current = 0;

            EnterNumber(0);
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Sum();

            choosenOperation = '-';

            result = current;

            resultLabel.Content = $"{result} - ";

            current = 0;

            EnterNumber(0);
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Sum();

            choosenOperation = '+';
            
            result = current;

            resultLabel.Content = $"{result} + ";

            current = 0;

            EnterNumber(0);
        }

        private void Plusminus_Click(object sender, RoutedEventArgs e)
        {
            current *= -1;

            currentLabel.Content = double.Parse(current.ToString());
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Sum();
        }

        // Numbers

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            EnterNumber(double.Parse(button.Content.ToString()));
        }
    }
}
