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

namespace _02_XML
{
    public partial class MainWindow : Form
    {
        private XmlDocument xDoc = new XmlDocument();
        private XmlElement xRoot;

        private void LoadColors()
        {
            // Load colors

            HashSet<string> gemsColors = new HashSet<string>();

            gemsColors.Add("");

            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                var gemSpecs = new List<string>();

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "color")
                    {
                        gemsColors.Add(childnode.InnerText);
                    }

                    gemSpecs.Add(childnode.InnerText);
                }

                gemsView.Rows.Add(gemSpecs.ToArray());
            }

            gemsColor.DataSource = gemsColors.ToList();
        }

        private void LoadGemsByColor(string color)
        {
            gemsView.Rows.Clear();

            foreach (XmlNode xnode in xRoot)
            {
                bool rightColor = color == "" ? true : false;
                var gemSpecs = new List<string>();

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "color")
                    {
                        if (childnode.InnerText == color)
                        {
                            rightColor = true;
                        }
                    }

                    gemSpecs.Add(childnode.InnerText);
                }

                if (rightColor)
                {
                    gemsView.Rows.Add(gemSpecs.ToArray());
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            // Load XML

            xDoc.Load(Path.Combine(Application.StartupPath.ToString(), "./Gems.xml"));
            xRoot = xDoc.DocumentElement;

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
