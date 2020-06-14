using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form : System.Windows.Forms.Form
    {
		public interface IObserver
		{
			void Update(ISubject subject, int x, int y);
		}

		public interface ISubject
		{
			void Add(IObserver observer);

			void Remove(IObserver observer);

		}

		public class MovableButton : Button, IObserver
		{
			public void Update(ISubject subject, int x, int y)
			{
				Location = new Point(Location.X + x, Location.Y + y);
			}
		}

		private class ControllerButton : ISubject
		{
			private List<IObserver> observers = new List<IObserver>();

			public Button CButton { get; set; }

			public ControllerButton(Button button)
			{
				CButton = button;
			}

			public void Add(IObserver observer)
			{
				observers.Add(observer);
			}

			public void Remove(IObserver observer)
			{
				observers.Remove(observer);
			}

			public void MoveObj(int x, int y)
			{
				foreach (var item in observers)
				{
					item.Update(this, x, y);
				}
			}
		}

		private void UI()
		{
			ControllerButton cButtonUp = new ControllerButton(buttonUp);
			ControllerButton cButtonDown = new ControllerButton(buttonDown);
			ControllerButton cButtonRight = new ControllerButton(buttonRight);
			ControllerButton cButtonLeft = new ControllerButton(buttonLeft);

			int marginTop = 10;
			int marginLeft = 20;

			for (int i = 0; i < 5; i++)
			{
				MovableButton button = new MovableButton();
				button.Left = marginLeft;
				button.Top = marginTop;
				button.Name = "buttonID" + i;
				button.Click += MoveButton;
				button.Text = "Click to select";
				button.BackColor = Color.White;
				button.Width = 100;
				button.FlatStyle = FlatStyle.Flat;
				button.FlatAppearance.BorderSize = 1;
				button.FlatAppearance.BorderColor = Color.LightGray;
				Controls.Add(button);
				marginTop += button.Height + 10;
			}

			void MoveButton(object sender, EventArgs eventArgs)
			{
				var button = (MovableButton)sender;

				if (button.BackColor != Color.Green)
				{
					button.BackColor = Color.Green;
					button.ForeColor = Color.White;
					button.Text = "Selected";
					cButtonUp.Add(button);
					cButtonDown.Add(button);
				}
				else
				{
					button.BackColor = Color.White;
					button.ForeColor = Color.Black;
					button.Text = "Click to select";
					cButtonUp.Remove(button);
					cButtonDown.Remove(button);
				}
			}

			cButtonUp.CButton.Click += ButtonUpClick;
			cButtonDown.CButton.Click += ButtonDownClick;
			cButtonRight.CButton.Click += ButtonRightClick;
			cButtonLeft.CButton.Click += ButtonLeftClick;

			void ButtonUpClick(object sender, EventArgs eventArgs)
			{
				cButtonUp.MoveObj(0, -3);
			}
			void ButtonDownClick(object sender, EventArgs eventArgs)
			{
				cButtonDown.MoveObj(0, +3);
			}
			void ButtonRightClick(object sender, EventArgs eventArgs)
			{
				cButtonUp.MoveObj(+3, 0);
			}
			void ButtonLeftClick(object sender, EventArgs eventArgs)
			{
				cButtonDown.MoveObj(-3, 0);
			}
		}

		public Form()
        {
            InitializeComponent();
			UI();
        }
	}
}
