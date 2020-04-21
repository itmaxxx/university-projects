using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SmartphoneFactory
{
	abstract class Smartphone
	{
		protected string Name;
		protected int RearCameraMP;
		protected int FrontCameraMP;
        protected double DisplaySize;
        protected int Storage;
        protected int RAM;

		public virtual void ShowInfo()
		{
			Console.WriteLine($"Name : {Name}\nRear Camera MP : {RearCameraMP}\nFront Camera MP : {FrontCameraMP}\nDisplay Size : {DisplaySize}\nStorage : {Storage}\nRAM : {RAM}");
		}

		public static Smartphone CreateSmartphone(string modelName)
		{
			Smartphone smartphone = null;

			if (modelName == "Samsung Note 10")
				smartphone = new SamsungNote10();
			else if (modelName == "Iphone X")
				smartphone = new IphoneX();
			else if (modelName == "Huawei P20")
				smartphone = new HuaweiP20();

			return smartphone;
		}
	}

	class SamsungNote10 : Smartphone
	{
		public SamsungNote10()
		{
			Name = "Samsung Note 10";
            RearCameraMP = 18;
            FrontCameraMP = 10;
            DisplaySize = 7.5;
            Storage = 512;
            RAM = 6;
		}
	}

	class IphoneX : Smartphone
	{
		public IphoneX()
		{
			Name = "Iphone X";
            RearCameraMP = 8;
            FrontCameraMP = 16;
            DisplaySize = 6.5;
            Storage = 128;
            RAM = 4;
		}
	}

    class HuaweiP20 : Smartphone
	{
		public HuaweiP20()
		{
			Name = "Huawei P20";
            RearCameraMP = 12;
            FrontCameraMP = 22;
            DisplaySize = 7.5;
            Storage = 512;
            RAM = 8;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Smartphone> smartphones = new List<Smartphone>();

			smartphones.Add(Smartphone.CreateSmartphone("Huawei P20"));
			smartphones.Add(Smartphone.CreateSmartphone("Samsung Note 10"));
			smartphones.Add(Smartphone.CreateSmartphone("Iphone X"));

			for (int i = 0; i < smartphones.Count; i++)
			{
				smartphones.ElementAt(i).ShowInfo();
			}
		}
	}
}
