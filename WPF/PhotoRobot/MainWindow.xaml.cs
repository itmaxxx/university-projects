using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
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

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// Load saves
			string[] filePaths = Directory.GetFiles("./", "*.txt");

			foreach (var file in filePaths)
			{
				listBoxSaves.Items.Add(file.Replace("./", "").Replace(".txt", ""));
			}
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

		private void Hair_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var comboBox = (ComboBox)sender;

			var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

			if (selectedItem.Content is null)
				return;

			var stackPanel = (StackPanel)selectedItem.Content;

			var selectedImage = (Image)stackPanel.Children[0];

			// Update mouth image
			Hair.Source = new BitmapImage(new Uri(selectedImage.Source.ToString()));
		}

		private void ListBoxSaves_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var listbox = (ListBox)sender;

			//Cannot add reference to System.Windows.Forms
			//var result = MessageBox.Show($"Вы точно хотите загрузить {listbox.SelectedItem.ToString()}?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			//if (result == DialogResult.No)
			//{
			//	return;
			//}

			TextReader tr = new StreamReader(listbox.SelectedItem.ToString() + ".txt");

			// Left ear
			string earSource = tr.ReadLine();
			LeftEar.Source = new BitmapImage(new Uri(earSource));
			LeftEarAngle.Value = Convert.ToDouble(tr.ReadLine());
			LeftEarScaleX.Value = Convert.ToDouble(tr.ReadLine());
			LeftEarScaleY.Value = Convert.ToDouble(tr.ReadLine());
			LeftEarSkewX.Value = Convert.ToDouble(tr.ReadLine());
			LeftEarSkewY.Value = Convert.ToDouble(tr.ReadLine());
			LeftEarTransformX.Value = Convert.ToDouble(tr.ReadLine());
			LeftEarTransformY.Value = Convert.ToDouble(tr.ReadLine());

			// Right ear
			RightEar.Source = new BitmapImage(new Uri(earSource));
			RightEarAngle.Value = Convert.ToDouble(tr.ReadLine());
			RightEarScaleX.Value = Convert.ToDouble(tr.ReadLine());
			RightEarScaleY.Value = Convert.ToDouble(tr.ReadLine());
			RightEarSkewX.Value = Convert.ToDouble(tr.ReadLine());
			RightEarSkewY.Value = Convert.ToDouble(tr.ReadLine());
			RightEarTransformX.Value = Convert.ToDouble(tr.ReadLine());
			RightEarTransformY.Value = Convert.ToDouble(tr.ReadLine());

			// Eyes
			Eyes.Source = new BitmapImage(new Uri(tr.ReadLine()));
			EyesAngle.Value = Convert.ToDouble(tr.ReadLine());
			EyesScaleX.Value = Convert.ToDouble(tr.ReadLine());
			EyesScaleY.Value = Convert.ToDouble(tr.ReadLine());
			EyesSkewX.Value = Convert.ToDouble(tr.ReadLine());
			EyesSkewY.Value = Convert.ToDouble(tr.ReadLine());
			EyesTransformX.Value = Convert.ToDouble(tr.ReadLine());
			EyesTransformY.Value = Convert.ToDouble(tr.ReadLine());

			// Nose
			Nose.Source = new BitmapImage(new Uri(tr.ReadLine()));
			NoseAngle.Value = Convert.ToDouble(tr.ReadLine());
			NoseScaleX.Value = Convert.ToDouble(tr.ReadLine());
			NoseScaleY.Value = Convert.ToDouble(tr.ReadLine());
			NoseSkewX.Value = Convert.ToDouble(tr.ReadLine());
			NoseSkewY.Value = Convert.ToDouble(tr.ReadLine());
			NoseTransformX.Value = Convert.ToDouble(tr.ReadLine());
			NoseTransformY.Value = Convert.ToDouble(tr.ReadLine());

			// Mouth
			Mouth.Source = new BitmapImage(new Uri(tr.ReadLine()));
			MouthAngle.Value = Convert.ToDouble(tr.ReadLine());
			MouthScaleX.Value = Convert.ToDouble(tr.ReadLine());
			MouthScaleY.Value = Convert.ToDouble(tr.ReadLine());
			MouthSkewX.Value = Convert.ToDouble(tr.ReadLine());
			MouthSkewY.Value = Convert.ToDouble(tr.ReadLine());
			MouthTransformX.Value = Convert.ToDouble(tr.ReadLine());
			MouthTransformY.Value = Convert.ToDouble(tr.ReadLine());

			// Hair
			Hair.Source = new BitmapImage(new Uri(tr.ReadLine()));
			HairAngle.Value = Convert.ToDouble(tr.ReadLine());
			HairScaleX.Value = Convert.ToDouble(tr.ReadLine());
			HairScaleY.Value = Convert.ToDouble(tr.ReadLine());
			HairSkewX.Value = Convert.ToDouble(tr.ReadLine());
			HairSkewY.Value = Convert.ToDouble(tr.ReadLine());
			HairTransformX.Value = Convert.ToDouble(tr.ReadLine());
			HairTransformY.Value = Convert.ToDouble(tr.ReadLine());

			tr.Close();
		}

		private void SaveCurrentRobot()
		{
			TextWriter tw = new StreamWriter(textBoxName.Text + ".txt");

			// Left ear
			tw.WriteLine(LeftEar.Source.ToString());
			tw.WriteLine(LeftEarAngle.Value);
			tw.WriteLine(LeftEarScaleX.Value);
			tw.WriteLine(LeftEarScaleY.Value);
			tw.WriteLine(LeftEarSkewX.Value);
			tw.WriteLine(LeftEarSkewY.Value);
			tw.WriteLine(LeftEarTransformX.Value);
			tw.WriteLine(LeftEarTransformY.Value);

			// Right ear
			tw.WriteLine(RightEarAngle.Value);
			tw.WriteLine(RightEarScaleX.Value);
			tw.WriteLine(RightEarScaleY.Value);
			tw.WriteLine(RightEarSkewX.Value);
			tw.WriteLine(RightEarSkewY.Value);
			tw.WriteLine(RightEarTransformX.Value);
			tw.WriteLine(RightEarTransformY.Value);

			// Eyes
			tw.WriteLine(Eyes.Source.ToString());
			tw.WriteLine(EyesAngle.Value);
			tw.WriteLine(EyesScaleX.Value);
			tw.WriteLine(EyesScaleY.Value);
			tw.WriteLine(EyesSkewX.Value);
			tw.WriteLine(EyesSkewY.Value);
			tw.WriteLine(EyesTransformX.Value);
			tw.WriteLine(EyesTransformY.Value);

			// Nose
			tw.WriteLine(Nose.Source.ToString());
			tw.WriteLine(NoseAngle.Value);
			tw.WriteLine(NoseScaleX.Value);
			tw.WriteLine(NoseScaleY.Value);
			tw.WriteLine(NoseSkewX.Value);
			tw.WriteLine(NoseSkewY.Value);
			tw.WriteLine(NoseTransformX.Value);
			tw.WriteLine(NoseTransformY.Value);

			// Mouth
			tw.WriteLine(Mouth.Source.ToString());
			tw.WriteLine(MouthAngle.Value);
			tw.WriteLine(MouthScaleX.Value);
			tw.WriteLine(MouthScaleY.Value);
			tw.WriteLine(MouthSkewX.Value);
			tw.WriteLine(MouthSkewY.Value);
			tw.WriteLine(MouthTransformX.Value);
			tw.WriteLine(MouthTransformY.Value);

			// Hair
			tw.WriteLine(Hair.Source.ToString());
			tw.WriteLine(HairAngle.Value);
			tw.WriteLine(HairScaleX.Value);
			tw.WriteLine(HairScaleY.Value);
			tw.WriteLine(HairSkewX.Value);
			tw.WriteLine(HairSkewY.Value);
			tw.WriteLine(HairTransformX.Value);
			tw.WriteLine(HairTransformY.Value);

			tw.Close();

			// Reload saved items list
			listBoxSaves.Items.Clear();

			string[] filePaths = Directory.GetFiles("./", "*.txt");

			foreach (var file in filePaths)
			{
				listBoxSaves.Items.Add(file.Replace("./", "").Replace(".txt", ""));
			}
		}

		private void ButtonSave_Click(object sender, RoutedEventArgs e)
		{
			SaveCurrentRobot();
		}

		private void TextBoxName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				SaveCurrentRobot();
			}
		}
	}
}
