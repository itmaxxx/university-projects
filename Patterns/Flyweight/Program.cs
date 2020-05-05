using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	enum UnitType
	{
		LightInfantry,
		Vehicle,
		HeavyVehicle,
		LightVehicle,
		Aircraft
	}

	class Unit
	{
		public UnitType type;
		public string name { get; protected set; }
		public int speed { get; protected set; }
		public int power { get; protected set; }

		public int x { get; protected set; }
		public int y { get; protected set; }

		public void Show(int x, int y)
		{
			Console.WriteLine($"Unit : {name}\nX : {x}, Y : {y}\nSpeed : {speed}\nPower : {power}\n");
		}

		public void setPosition(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}

	class LightInfantry : Unit
	{
		public LightInfantry()
		{
			name = "Light Infantry";
			speed = 20;
			power = 10;
			type = UnitType.LightInfantry;
		}
	}

	class Vehicle : Unit
	{
		public Vehicle()
		{
			name = "Vehicle";
			speed = 70;
			power = 0;
			type = UnitType.Vehicle;
		}
	}

	class HeavyVehicle : Unit
	{
		public HeavyVehicle()
		{
			name = "Heavy Vehicle";
			speed = 15;
			power = 150;
			type = UnitType.HeavyVehicle;
		}
	}

	class LightVehicle : Unit
	{
		public LightVehicle()
		{
			name = "Light Vehicle";
			speed = 50;
			power = 30;
			type = UnitType.LightVehicle;
		}
	}

	class Aircraft : Unit
	{
		public Aircraft()
		{
			name = "Aircraft";
			speed = 300;
			power = 100;
			type = UnitType.Aircraft;
		}
	}

	class UnitFactory
	{
		private Dictionary<UnitType, Unit> existingUnitTypes = new Dictionary<UnitType, Unit>();

		public Unit spawnUnit(UnitType type, int x, int y)
		{
			Unit unit = null;

			if (existingUnitTypes.ContainsKey(type))
			{
				unit = existingUnitTypes[type];

				unit.Show(x, y);
			}
			else
			{
				switch (type)
				{
					case UnitType.LightInfantry:
						unit = new LightInfantry();
						break;
					case UnitType.Vehicle:
						unit = new Vehicle();
						break;
					case UnitType.HeavyVehicle:
						unit = new HeavyVehicle();
						break;
					case UnitType.LightVehicle:
						unit = new LightVehicle();
						break;
					case UnitType.Aircraft:
						unit = new Aircraft();
						break;
					default:
						throw new Exception("Unexpected Unit Type");
				}

				existingUnitTypes.Add(type, unit);

				unit.Show(x, y);
			}

			return unit;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			UnitFactory factory = new UnitFactory();

			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					factory.spawnUnit(UnitType.LightInfantry, x, y);
				}
			}

			for (int x = 0; x < 10; x++)
			{
				factory.spawnUnit(UnitType.Vehicle, x, 10);
			}

			for (int x = 0; x < 10; x++)
			{
				factory.spawnUnit(UnitType.LightInfantry, x, 15);
			}

			for (int x = 0; x < 10; x++)
			{
				factory.spawnUnit(UnitType.HeavyVehicle, x, 20);
			}

			for (int x = 0; x < 10; x++)
			{
				factory.spawnUnit(UnitType.Aircraft, x, 25);
			}

			Console.ReadKey();
		}
	}
}
