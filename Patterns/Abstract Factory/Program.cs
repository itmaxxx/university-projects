using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	abstract class Continent
	{
		public string Name { get; protected set; }

		public abstract Herbivore CreateHerbivore();
		public abstract Carnivore CreateCarnivore();
	}

	class Africa : Continent
	{
		private Africa() { }
		private static Africa africa;

		public static Africa GetContinent()
		{
			if (africa == null)
			{
				africa = new Africa();
			}

			return africa;
		}

		public override Herbivore CreateHerbivore()
		{
			return new Wildebeest();
		}

		public override Carnivore CreateCarnivore()
		{
			return new Lion();
		}
	}

	class NorthAmerica : Continent
	{
		private NorthAmerica() { }
		private static NorthAmerica NA;

		public static NorthAmerica GetContinent()
		{
			if (NA == null)
			{
				NA = new NorthAmerica();
			}

			return NA;
		}

		public override Herbivore CreateHerbivore()
		{
			return new Elk();
		}

		public override Carnivore CreateCarnivore()
		{
			return new Wolf();
		}
	}

	class Eurasion : Continent
	{
		private Eurasion() { }
		private static Eurasion eurasion;

		public static Eurasion GetContinent()
		{
			if (eurasion == null)
			{
				eurasion = new Eurasion();
			}

			return eurasion;
		}

		public override Herbivore CreateHerbivore()
		{
			return new Wildebeest();
		}

		public override Carnivore CreateCarnivore()
		{
			return new Tiger();
		}
	}

	abstract class Herbivore
	{
		public string Name { get; protected set; }
		public int Weight { get; protected set; }
		public bool Life { get; protected set; }

		public virtual void EatGrass()
		{
			Weight += 10;

			Console.WriteLine($"{Name} eats grass and gets 10 weight");
		}
	}

	class Wildebeest : Herbivore
	{
		public Wildebeest()
		{
			Name = "Wildebeest";
			Weight = 100;
			Life = true;
		}
	}

	class Bison : Herbivore
	{
		public Bison()
		{
			Name = "Bison";
			Weight = 120;
			Life = true;
		}
	}

	class Elk : Herbivore
	{
		public Elk()
		{
			Name = "Elk";
			Weight = 180;
			Life = true;
		}
	}

	abstract class Carnivore
	{
		public string Name { get; protected set; }
		public int Power { get; protected set; }

		public virtual void Eat(Herbivore herbivore)
		{
			if (this.Power > herbivore.Weight)
			{
				Power += 10;

				Console.WriteLine($"{Name} eaten {herbivore.Name} and got 10 power");
			}
			else
			{
				Power -= 10;

				Console.WriteLine($"{Name} tried to eat {herbivore.Name} but failed and lost 10 power");
			}
		}
	}

	class Lion : Carnivore
	{
		public Lion()
		{
			Name = "Lion";
			Power = 100;
		}
	}

	class Wolf : Carnivore
	{
		public Wolf()
		{
			Name = "Wolf";
			Power = 80;
		}
	}

	class Tiger : Carnivore
	{
		public Tiger()
		{
			Name = "Tiger";
			Power = 70;
		}
	}

	class AnimalWorld
	{
		public void MealsHerbivores(Continent continent)
		{
			var herbivore = continent.CreateHerbivore();

			herbivore.EatGrass();
		}

		public void NutritionCarnivores(Continent continent)
		{
			var herbivore = continent.CreateHerbivore();
			var carnivore = continent.CreateCarnivore();

			carnivore.Eat(herbivore);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			AnimalWorld AW = new AnimalWorld();

			Africa africa = Africa.GetContinent();

			AW.MealsHerbivores(africa);
			AW.NutritionCarnivores(africa);
		}
	}
}
