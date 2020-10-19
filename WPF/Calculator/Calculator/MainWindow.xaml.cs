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
        private int result = 0;
        private int current = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Logic

        private void EnterNumber(int number)
        {
            current = current == 0 ? number : int.Parse(current.ToString() + number.ToString());

            currentLabel.Content = current;
        }

        // Cleaners

        private void Ce_Click(object sender, RoutedEventArgs e)
        {
            currentLabel.Content = 0;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }

        // Math operations

        private void Divide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            result = current;

            choosenOperation = '+';

            current = 0;

            EnterNumber(0);
        }

        private void Plusminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (choosenOperation == '+')
            {
                currentLabel.Content = result + current;

                MessageBox.Show($"{result} + {current}");

                result = 0;

                resultLabel.Content = result;
            }
        }

        // Numbers

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(0);
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(1);
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(2);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(3);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(4);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(5);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(6);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(7);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(8);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            EnterNumber(9);
        }


    }
}
