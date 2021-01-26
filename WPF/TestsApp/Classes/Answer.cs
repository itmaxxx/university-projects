using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsApp.Classes
{
	public class Answer
	{
		public string Text { get; set; }
		public bool IsRight { get; set; }

		public Answer(string text, bool isRight)
		{
			Text = text;
			IsRight = isRight;
		}
	}
}
