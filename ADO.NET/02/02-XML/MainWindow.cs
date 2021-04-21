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
        public MainWindow()
        {
            InitializeComponent();

            HashSet<string> gemsColors = new HashSet<string>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path.Combine(Application.StartupPath.ToString(), "./Gems.xml"));

            gemsColors.Add("");

            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                //MessageBox.Show(xnode.ChildNodes[0].InnerText);
                //MessageBox.Show(xnode.Attributes.GetNamedItem("color").InnerText);

                // получаем атрибут name
                //if (xnode.Attributes.Count > 0)
                //{
                //    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                //    if (attr != null)
                //    {
                //        Console.WriteLine(attr.Value);
                //    }
                //}

                var gemSpecs = new List<string>();

                //обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
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
    }
}
