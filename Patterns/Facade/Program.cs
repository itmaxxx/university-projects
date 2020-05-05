using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	class VideoCard
	{
		public string name { get; private set; }

		public VideoCard()
		{
			name = "Video Card";
		}

		public void Launch()
		{
			Console.WriteLine($"{name} : Launch");
		}

		public void CheckConnectionWithMonitor()
		{
			Console.WriteLine($"{name} : CheckConnectionWithMonitor");
		}

		public void DisplayInformationAboutRAM()
		{
			Console.WriteLine($"{name} : DisplayInformationAboutRAM");
		}

		public void DisplayInformationAboutDiskReader()
		{
			Console.WriteLine($"{name} : DisplayInformationAboutDiskReader");
		}

		public void DisplayInformationAboutHardDrive()
		{
			Console.WriteLine($"{name} : DisplayInformationAboutHardDrive");
		}

		public void DisplayFarewellMessageOnTheMonitor()
		{
			Console.WriteLine($"{name} : DisplayFarewellMessageOnTheMonitor");
		}
	}

	class RAM
	{
		public string name { get; private set; }

		public RAM()
		{
			name = "RAM";
		}

		public void LaunchDevices()
		{
			Console.WriteLine($"{name} : LaunchDevices");
		}

		public void AnalyzeMemory()
		{
			Console.WriteLine($"{name} : AnalyzeMemory");
		}

		public void CleanMemory()
		{
			Console.WriteLine($"{name} : CleanMemory");
		}
	}

	class Winchester
	{
		public string name { get; private set; }

		public Winchester()
		{
			name = "Winchester";
		}

		public void Launch()
		{
			Console.WriteLine($"{name} : Launch");
		}

		public void CheckBootSector()
		{
			Console.WriteLine($"{name} : CheckBootSector");
		}

		public void Stop()
		{
			Console.WriteLine($"{name} : Stop");
		}
	}

	class OpticalDiscReader
	{
		public string name { get; private set; }

		public OpticalDiscReader()
		{
			name = "OpticalDiscReader";
		}

		public void Launch()
		{
			Console.WriteLine($"{name} : Launch");
		}

		public void CheckDiskAvailability()
		{
			Console.WriteLine($"{name} : CheckDiskAvailability");
		}

		public void ReturnToStartingPosition()
		{
			Console.WriteLine($"{name} : ReturnToStartingPosition");
		}
	}

	class PowerSupply
	{
		public string name { get; private set; }

		public PowerSupply()
		{
			name = "PowerSupply";
		}

		public void ApplyPower()
		{
			Console.WriteLine($"{name} : ApplyPower");
		}

		public void ApplyPowerToTheVideoCard()
		{
			Console.WriteLine($"{name} : ApplyPowerToTheVideoCard");
		}

		public void ApplyPowerToTheRAM()
		{
			Console.WriteLine($"{name} : ApplyPowerToTheRAM");
		}

		public void ApplyPowerToTheDiskDrive()
		{
			Console.WriteLine($"{name} : ApplyPowerToTheDiskDrive");
		}

		public void ApplyPowerToTheHardDrive()
		{
			Console.WriteLine($"{name} : ApplyPowerToTheHardDrive");
		}

		public void StopPoweringTheVideoCard()
		{
			Console.WriteLine($"{name} : StopPoweringTheVideoCard");
		}

		public void StopPoweringRAM()
		{
			Console.WriteLine($"{name} : StopPoweringRAM");
		}

		public void StopPoweringTheDiskReader()
		{
			Console.WriteLine($"{name} : StopPoweringTheDiskReader");
		}

		public void StopPoweringTheHardDrive()
		{
			Console.WriteLine($"{name} : StopPoweringTheHardDrive");
		}

		public void Shutdown()
		{
			Console.WriteLine($"{name} : Shutdown");
		}
	}

	class Sensors
	{
		public string name { get; private set; }

		public Sensors()
		{
			name = "Sensors";
		}

		public void CheckVoltage()
		{
			Console.WriteLine($"{name} : CheckVoltage");
		}

		public void CheckTheTemperatureInThePowerSupply()
		{
			Console.WriteLine($"{name} : CheckTheTemperatureInThePowerSupply");
		}

		public void CheckTheTemperatureInTheVideoCard()
		{
			Console.WriteLine($"{name} : CheckTheTemperatureInTheVideoCard");
		}

		public void CheckTheTemperatureInTheRAM()
		{
			Console.WriteLine($"{name} : CheckTheTemperatureInTheRAM");
		}

		public void CheckTheTemperatureOfAllsystems()
		{
			Console.WriteLine($"{name} : CheckTheTemperatureOfAllsystems");
		}

		public void finish()
		{
			Console.WriteLine($"{name} : finish");
		}
	}

	class PC
	{
		private VideoCard vc;
		private RAM ram;
		private Winchester winchester;
		private OpticalDiscReader odr;
		private PowerSupply ps;
		private Sensors sensors;

		public PC()
		{
			vc = new VideoCard();
			ram = new RAM();
			winchester = new Winchester();
			odr = new OpticalDiscReader();
			ps = new PowerSupply();
			sensors = new Sensors();
		}

		public void Start()
		{
			Console.WriteLine("Starting PC ...\n   It may take a few minutes ...");

			ps.ApplyPower();
			sensors.CheckVoltage();
			sensors.CheckTheTemperatureInThePowerSupply();
			sensors.CheckTheTemperatureInTheVideoCard();
			ps.ApplyPowerToTheVideoCard();
			vc.Launch();
			vc.CheckConnectionWithMonitor();
			sensors.CheckTheTemperatureInTheRAM();
			ps.ApplyPowerToTheRAM();
			ram.LaunchDevices();
			ram.AnalyzeMemory();
			vc.DisplayInformationAboutRAM();
			ps.ApplyPowerToTheDiskDrive();
			odr.Launch();
			odr.CheckDiskAvailability();
			vc.DisplayInformationAboutDiskReader();
			ps.ApplyPowerToTheHardDrive();
			winchester.Launch();
			winchester.CheckBootSector();
			vc.DisplayInformationAboutHardDrive();
			sensors.CheckTheTemperatureOfAllsystems();
		}

		public void Shutdown()
		{
			Console.WriteLine("Shutting Down PC ...\n   Please, be patient ...");

			winchester.Stop();
			ram.CleanMemory();
			ram.AnalyzeMemory();
			vc.DisplayFarewellMessageOnTheMonitor();
			odr.ReturnToStartingPosition();
			ps.StopPoweringTheVideoCard();
			ps.StopPoweringRAM();
			ps.StopPoweringTheDiskReader();
			ps.StopPoweringTheHardDrive();
			sensors.CheckVoltage();
			ps.Shutdown();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			PC pc = new PC();

			pc.Start();

			pc.Shutdown();
		}
	}
}
