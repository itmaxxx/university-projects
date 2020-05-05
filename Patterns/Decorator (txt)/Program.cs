using System;

namespace Decorator
{
    abstract class Card
	{
		public abstract void Operation();
	}

	class ElectronicCard : Card
	{
		public override void Operation()
		{
			Console.WriteLine("Electronic Card");
		}
	}

	abstract class UniversalCard : Card
	{
		protected Card card;

		public UniversalCard(Card card)
		{
			this.card = card;
		}

		public void SetComponent(Card card)
		{
			this.card = card;
		}

		public void Remove()
		{
			card = null;
		}

		public override void Operation()
		{
			if (card != null)
			{
				Console.WriteLine("Ultra Card");
			}
			else
			{
				Console.Write("");
			}
		}
	}

	class Passport : UniversalCard
	{
		public Passport(Card card) : base(card)
		{
		}

		public override void Operation()
		{
			Console.WriteLine("Passport");
		}
	}

	class BankCard : UniversalCard
	{
		public BankCard(Card card) : base(card)
		{
		}

		public override void Operation()
		{
			Console.WriteLine("Bank Card");
		}
	}

	class Insurance : UniversalCard
	{
		public Insurance(Card card) : base(card)
		{
		}

		public override void Operation()
		{
			Console.WriteLine("Insurance policy");
		}
	}

	class Client
	{
		public void Operation(Card card)
		{
			card.Operation();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			ElectronicCard card = new ElectronicCard();
			client.Operation(card);

			Passport passport = new Passport(card);
			client.Operation(passport);

			Insurance insurance = new Insurance(card);
			client.Operation(insurance);
		}
	}
}
