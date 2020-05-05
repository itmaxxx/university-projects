using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CarType { sedan, coupe, universal, hatchback }

public enum TransmissionTypes { automatic, manual, robot }

namespace Builder
{
	class Car
	{
		public string Name { get; set; }
		public CarType Type { get; set; }
		public int HP { get; set; }
		public int WheelsRadius { get; set; }
		public int GearStages { get; set; }
		public TransmissionTypes Transmission { get; set; }

		public void ShowInfo()
		{
			Console.WriteLine($"Car name: {Name}");
			Console.WriteLine($"Type: {Type}");
			Console.WriteLine($"HP: {HP}");
			Console.WriteLine($"WheelsRadius: {WheelsRadius}");
			Console.WriteLine($"GearStages: {GearStages}");
			Console.WriteLine($"Transmission: {Transmission}");
		}
	}

	abstract class ConcreteBuilder
	{
		public Car car { get; protected set; }

		public ConcreteBuilder()
		{
			car = new Car();
		}

		public abstract void SetName();
		public abstract void SetCarType();
		public abstract void SetHP();
		public abstract void SetWheelsRadius();
		public abstract void SetGearsStages();
		public abstract void SetTransmission();
	}

	class DaewooLanosBuilder : ConcreteBuilder
	{
		public override void SetName()
		{
			car.Name = "Daewoo Lanos";
		}

		public override void SetCarType()
		{
			car.Type = CarType.sedan;
		}

		public override void SetHP()
		{
			car.HP = 98;
		}

		public override void SetWheelsRadius()
		{
			car.WheelsRadius = 13;
		}

		public override void SetGearsStages()
		{
			car.GearStages = 5;
		}

		public override void SetTransmission()
		{
			car.Transmission = TransmissionTypes.manual;
		}
	}

	class FordProbeBuilder : ConcreteBuilder
	{
		public override void SetName()
		{
			car.Name = "Ford Probe";
		}

		public override void SetCarType()
		{
			car.Type = CarType.coupe;
		}

		public override void SetHP()
		{
			car.HP = 160;
		}

		public override void SetWheelsRadius()
		{
			car.WheelsRadius = 14;
		}

		public override void SetGearsStages()
		{
			car.GearStages = 4;
		}

		public override void SetTransmission()
		{
			car.Transmission = TransmissionTypes.automatic;
		}
	}

	class UAZPatriotBuilder : ConcreteBuilder
	{
		public override void SetName()
		{
			car.Name = "UAZ Patriot";
		}

		public override void SetCarType()
		{
			car.Type = CarType.universal;
		}

		public override void SetHP()
		{
			car.HP = 120;
		}

		public override void SetWheelsRadius()
		{
			car.WheelsRadius = 16;
		}

		public override void SetGearsStages()
		{
			car.GearStages = 4;
		}

		public override void SetTransmission()
		{
			car.Transmission = TransmissionTypes.manual;
		}
	}

	class HyundaiGetzBuilder : ConcreteBuilder
	{
		public override void SetName()
		{
			car.Name = "Hyundai Getz";
		}

		public override void SetCarType()
		{
			car.Type = CarType.hatchback;
		}

		public override void SetHP()
		{
			car.HP = 66;
		}

		public override void SetWheelsRadius()
		{
			car.WheelsRadius = 13;
		}

		public override void SetGearsStages()
		{
			car.GearStages = 4;
		}

		public override void SetTransmission()
		{
			car.Transmission = TransmissionTypes.automatic;
		}
	}

	class Shop
	{
		public Car BuildCar(ConcreteBuilder builder)
		{
			builder.SetName();
			builder.SetCarType();
			builder.SetHP();
			builder.SetWheelsRadius();
			builder.SetGearsStages();
			builder.SetTransmission();

			return builder.car;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Shop shop = new Shop();

			Car UAZ = shop.BuildCar(new UAZPatriotBuilder());

			UAZ.ShowInfo();
		}
	}
}
