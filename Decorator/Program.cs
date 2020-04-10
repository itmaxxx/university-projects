using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	abstract class Unit
	{
		protected string name;

		public Unit(string name)
		{
			this.name = name;
		}

		public string GetName()
		{
			return name;
		}

		public abstract int GetAttack();

		public abstract int GetSpeed();

		public abstract int GetHealth();

		public abstract int GetProtection();

		public void Show()
		{
			Console.WriteLine($"Name : {name}\nAttack : {GetAttack()}");
		}
	}

	class Human : Unit
	{
		public Human() : base("Human")
		{
		}

		public override int GetAttack()
		{
			return 20;
		}

		public override int GetSpeed()
		{
			return 20;
		}

		public override int GetHealth()
		{
			return 150;
		}

		public override int GetProtection()
		{
			return 0;
		}
	}

	class Elf : Unit
	{
		public Elf() : base("Elf")
		{
		}

		public override int GetAttack()
		{
			return 15;
		}

		public override int GetSpeed()
		{
			return 30;
		}

		public override int GetHealth()
		{
			return 100;
		}

		public override int GetProtection()
		{
			return 0;
		}
	}

	abstract class UnitDecorator : Unit
	{
		protected Unit unit;

		public UnitDecorator(string name, Unit unit) : base(name)
		{
			this.unit = unit;
		}
	}

	class HumanWarrior : UnitDecorator
	{
		public HumanWarrior(Human human) : base("Human Warrior", human)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 20;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 50;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 20;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 10;
		}
	}

	class Swordsman : UnitDecorator
	{
		public Swordsman(HumanWarrior humanWarrior) : base("Swordsman", humanWarrior)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 40;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 50;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 40;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() - 10;
		}
	}

	class Archer : UnitDecorator
	{
		public Archer(HumanWarrior humanWarrior) : base("Archer", humanWarrior)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 20;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 50;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 100;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 20;
		}
	}

	class Rider : UnitDecorator
	{
		public Rider(Swordsman swordsman) : base("Rider", swordsman)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() - 10;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 200;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 100;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 40;
		}
	}

	class ElfWarrior : UnitDecorator
	{
		public ElfWarrior(Elf elf) : base("Elf Warrior", elf)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 20;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 100;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 20;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() - 10;
		}
	}

	class ElfMagician : UnitDecorator
	{
		public ElfMagician(Elf elf) : base("Elf Magician", elf)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 10;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() - 50;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 10;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 10;
		}
	}

    class Arbalester : UnitDecorator
	{
		public Arbalester(ElfWarrior elfWarrior) : base("Arbalester", elfWarrior)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 20;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 50;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() - 10;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 10;
		}
	}

    class EvilMagician : UnitDecorator
	{
		public EvilMagician(ElfMagician elfMagician) : base("Evil Magician", elfMagician)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 70;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 0;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 0;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 20;
		}
	}

    class GoodMagician : UnitDecorator
	{
		public GoodMagician(ElfMagician elfMagician) : base("Good Magician", elfMagician)
		{
		}

		public override int GetAttack()
		{
			return unit.GetAttack() + 50;
		}

		public override int GetHealth()
		{
			return unit.GetHealth() + 100;
		}

		public override int GetProtection()
		{
			return unit.GetProtection() + 30;
		}

		public override int GetSpeed()
		{
			return unit.GetSpeed() + 30;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Swordsman sw = new Swordsman(new HumanWarrior(new Human()));
			sw.Show();

            EvilMagician em = new EvilMagician(new ElfMagician(new Elf()));
            em.Show();
		}
	}
}