using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteMap
{
	public partial class MainForm : Form
	{
		CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

		public MainForm()
		{
			InitializeComponent();
		}

		private string FixLink(string parsingUrl, string link)
		{
			Regex regex = new Regex($"{parsingUrl}");

			if (!regex.Match(link).Success)
			{
				link = $"{parsingUrl}{((link.ElementAt(0) != '/' && parsingUrl.ElementAt(parsingUrl.Length - 1) != '/') ? "/" : "")}{link}";
			}

			return link;
		}

		private void ParseTag(HtmlAgilityPack.HtmlDocument doc, List<string> links, string tag, string param)
		{
			try
			{
				var tags = doc.DocumentNode.SelectNodes($"//{tag}");

				if (tags != null)
				{
					foreach (HtmlNode t in tags)
					{
						var value = t.GetAttributeValue(param, "");

						if (value.Length == 0 || value.IndexOf('#') != -1)
						{
							return;
						}

						if (links.Where(l => l.Equals(value)).ToArray().Length == 0)
						{
							links.Add(value);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private List<string> ParsePageLinks(string url)
		{
			var links = new List<string>();

			var doc = new HtmlWeb().Load(url);

			ParseTag(doc, links, "a", "href");

			return links;
		}

		private void ParseWebPage(string siteUrl, string url = "", string level = "")
		{
			if (url.Length == 0)
				url = siteUrl;

			Regex regex = new Regex($"{url}");

			var links = ParsePageLinks(url);

			textBoxMap.Text += $"{level}+{url}\r\n";

			for (int i = 0; i < links.Count; i++)
			{
				links[i] = FixLink(siteUrl, links[i]);

				textBoxMap.Text += $"{level}- {links[i]}\r\n";

				if (!regex.Match(links[i]).Success)
				{
					continue;
				}
			}
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			textBoxMap.Clear();

			Task parse = new Task(() => {
				buttonStart.Enabled = false;
				ParseWebPage(textBoxUrl.Text);
				buttonStart.Enabled = true;
			});
			parse.Start();
		}
	}
}
