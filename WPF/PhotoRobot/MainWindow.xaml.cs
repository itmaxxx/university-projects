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

	class FacePart
	{
		public Image Image { get; private set; }
		public int Height { get; private set; }
		public int Width { get; private set; }
		public int TransformX { get; private set; }
		public int TransformY { get; private set; }
		public int Angle { get; private set; }
		public int SkewX { get; private set; }
		public int SkewY { get; private set; }
		public int ScaleX { get; private set; }
		public int ScaleY { get; private set; }

		public FacePart(string source, int height, int width, int transformX, int transformY, int angle, int skewX, int skewY, int scaleX, int scaleY)
		{
			Image = new Image();
			Image.Height = height;
			Image.Width = width;
			Image.Stretch = Stretch.Fill;
			Image.Source = new BitmapImage(new Uri(source));

			SetTransform(transformX, transformY, angle, skewX, skewY, scaleX, scaleY);
		}

		public void SetTransform(int transformX, int transformY, int angle, int skewX, int skewY, int scaleX, int scaleY)
		{
			TransformX = transformX;
			TransformY = transformY;
			Angle = angle;
			SkewX = skewX;
			SkewY = skewY;
			ScaleX = scaleX;
			ScaleY = scaleY;

			ApplyTransform();
		}

		public void ApplyTransform()
		{
			TransformGroup transformGroup = new TransformGroup();
			transformGroup.Children.Add(new TranslateTransform(TransformX, TransformY));
			transformGroup.Children.Add(new SkewTransform(SkewX, SkewY));
			transformGroup.Children.Add(new ScaleTransform(ScaleX, ScaleY));
			transformGroup.Children.Add(new RotateTransform(Angle));

			Image.RenderTransform = transformGroup;
		}
	}

	class Face
	{
		public FacePart LeftEar { get; private set; }
		public FacePart RightEar { get; private set; }

		public Face(string earsImage)
		{
			LeftEar = new FacePart(earsImage, 100, 40, -55, 0, -5, 0, 0, 1, 1);
			RightEar = new FacePart(earsImage, 100, 40, -55, 0, 5, 0, 0, -1, 1);
		}

		// grid -> stack panel?
		public void AddToGrid(Grid grid, int row, int column)
		{
			grid.Children.Add(LeftEar.Image);
			Grid.SetRow(LeftEar.Image, row);
			Grid.SetColumn(LeftEar.Image, column);

			grid.Children.Add(RightEar.Image);
			Grid.SetRow(RightEar.Image, row);
			Grid.SetColumn(RightEar.Image, column);
		}
	}

	public partial class MainWindow : Window
	{
		Face face;

		public MainWindow()
		{
			InitializeComponent();

			face = new Face("pack://application:,,,/PhotoRobot;component/Resources/Ears/ear1.jpg");

			face.AddToGrid(mainGrid, 0, 1);
		}

		private void ComboBox_SelectionChanged(object sender, RoutedEventArgs e)
		{
			var comboBox = (ComboBox)sender;

			var selectedItem = (ComboBoxItem)comboBox.SelectedItem;

			if (selectedItem.Content is null)
				return;

			var stackPanel = (StackPanel)selectedItem.Content;

			var selectedImage = (Image)stackPanel.Children[0];

			MessageBox.Show(selectedImage.Source.ToString());
		}
	}
}
