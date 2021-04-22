using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

namespace _02_XML
{
    public partial class MainWindow : Form
    {
        private XElement gems;

        private void LoadColors()
        {
            HashSet<string> gemsColors = new HashSet<string>();

            gemsColors.Add("");

            IEnumerable<XElement> allGemsColors = from item in gems.Elements()
                                                  select item.Element("color");

            foreach (string color in allGemsColors)
            {
                gemsColors.Add(color);
            }

            gemsColor.DataSource = gemsColors.ToArray();
        }

        private void LoadGemsByColor(string color)
        {
            gemsView.Rows.Clear();

            IEnumerable<XElement> gemsByColor = from item in gems.Elements()
                                                where (string)item.Element("color") == color
                                                select item;

            foreach (var gem in gemsByColor)
            {
                IEnumerable<string> gemSpecs = from item in gem.Elements()
                                               select item.Value;

                gemsView.Rows.Add(gemSpecs.ToArray());
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            // Load XML

            var filename = "Gems.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var gemsFile = Path.Combine(currentDirectory, filename);

            gems = XElement.Load(gemsFile);

            // Load colors

            LoadColors();
        }

        private void gemsColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            string selectedColor = cb.SelectedItem.ToString();

            LoadGemsByColor(selectedColor);
        }
    }
}
