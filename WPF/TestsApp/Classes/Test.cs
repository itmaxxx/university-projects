using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsApp.Classes
{
	public class Test
	{
		public string Title { get; set; }
		public List<Question> Questions { get; set; }

		public Test(string title, List<Question> questions)
		{
			Title = title;
			Questions = questions;
		}
	}
}
