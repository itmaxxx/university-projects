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

namespace PhotoRobot
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>

	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		// Change ears
		private void Ears_SelectionChanged(object sender, RoutedEventArgs e)
		{
			var comboBox = (ComboBox)sender;

			var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

			if (selectedItem.Content is null)
				return;

			var stackPanel = (StackPanel)selectedItem.Content;

			var selectedImage = (Image)stackPanel.Children[0];

			// Update left ear image
			LeftEar.Source = new BitmapImage(new Uri(selectedImage.Source.ToString()));

			// Update right ear image
			RightEar.Source = new BitmapImage(new Uri(selectedImage.Source.ToString()));

			// Display selected image source
			// MessageBox.Show(selectedImage.Source.ToString());
		}

        private void Eyes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			var comboBox = (ComboBox)sender;

			var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

			if (selectedItem.Content is null)
				return;

			var stackPanel = (StackPanel)selectedItem.Content;

			var selectedImage = (Image)stackPanel.Children[0];

			// Update eyes image
			Eyes.Source = new BitmapImage(new Uri(selectedImage.Source.ToString()));
		}

        private void Nose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			var comboBox = (ComboBox)sender;

			var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

			if (selectedItem.Content is null)
				return;

			var stackPanel = (StackPanel)selectedItem.Content;

			var selectedImage = (Image)stackPanel.Children[0];

			// Update nose image
			Nose.Source = new BitmapImage(new Uri(selectedImage.Source.ToString()));
		}

        private void Mouth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			var comboBox = (ComboBox)sender;

			var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

			if (selectedItem.Content is null)
				return;

			var stackPanel = (StackPanel)selectedItem.Content;

			var selectedImage = (Image)stackPanel.Children[0];

			// Update mouth image
			Mouth.Source = new BitmapImage(new Uri(selectedImage.Source.ToString()));
		}
    }
}
