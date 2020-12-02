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

namespace ImageTransformation
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
			// Set height data
			MaxImageHeight.Content = GridContainer.ActualHeight;
			ImageHeight.Maximum = GridContainer.ActualHeight;
			ImageHeight.Value = GridContainer.ActualHeight;
			
			// Set width data
			MaxImageWidth.Content = GridContainer.ActualWidth / 2;
			ImageWidth.Maximum = GridContainer.ActualWidth / 2;
			ImageWidth.Value = GridContainer.ActualWidth / 2;

			// Set transform x data
			MinTransformX.Content = -CurrentImage.ActualWidth;
			MaxTransformX.Content = CurrentImage.ActualWidth;
			TransformX.Minimum = -CurrentImage.ActualWidth;
			TransformX.Maximum = CurrentImage.ActualWidth;

			// Set transform y data
			MinTransformY.Content = -CurrentImage.ActualHeight;
			MaxTransformY.Content = CurrentImage.ActualHeight;
			TransformY.Minimum = -CurrentImage.ActualHeight;
			TransformY.Maximum = CurrentImage.ActualHeight;
		}

		// Update valuew when size changed
		private void GridContainer_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			// Set max height
			MaxImageHeight.Content = GridContainer.ActualHeight;
			ImageHeight.Maximum = GridContainer.ActualHeight;
			//ImageHeight.Value = GridContainer.ActualHeight;

			// Set max width
			MaxImageWidth.Content = GridContainer.ActualWidth / 2;
			ImageWidth.Maximum = GridContainer.ActualWidth / 2;
			//ImageWidth.Value = GridContainer.ActualWidth / 2;
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			if (CurrentImage == null)
				return;

			RadioButton radioButton = (RadioButton)sender;

			try
			{
				CurrentImage.Source = new BitmapImage(new Uri($"Resources/{radioButton.Content.ToString().Replace(' ', '_')}.jpg", UriKind.Relative));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				radioButton.IsChecked = false;
			}
		}

		private void ImageHeight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (CurrentImage == null)
				return;

			CurrentImage.Height = e.NewValue;
		}
		private void ImageWidth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (CurrentImage == null)
				return;

			CurrentImage.Width = e.NewValue;
		}

		private void RenderTransform_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (CurrentImage == null)
				return;

			TransformGroup transformGroup = new TransformGroup();
			transformGroup.Children.Add(new TranslateTransform(TransformX.Value, TransformY.Value));
			transformGroup.Children.Add(new SkewTransform(SkewX.Value, SkewY.Value));
			transformGroup.Children.Add(new RotateTransform(Rotate.Value));

			CurrentImage.RenderTransform = transformGroup;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ImageHeight.Value = GridContainer.ActualHeight;
			ImageWidth.Value = GridContainer.ActualWidth / 2;
			TransformX.Value = 0;
			TransformY.Value = 0;
			SkewX.Value = 0;
			SkewY.Value = 0;
			Rotate.Value = 0;
		}
	}
}
