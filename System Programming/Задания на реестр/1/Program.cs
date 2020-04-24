using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace NetCoreRegistry
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\MaxD\StartTime"))
				{
					if (key != null && key.GetValue("LastStartTime") != null)
					{
						string time = key.GetValue("LastStartTime").ToString();

						Console.WriteLine($"Last start time : {time}");
					}
				}

				using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\MaxD\StartTime"))
				{
					key.SetValue("LastStartTime", $"{DateTime.UtcNow:dd.MM.yyyy HH:mm:ss}");
				}

				using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run"))
				{
					key.SetValue("MaxD", $"{AppDomain.CurrentDomain.BaseDirectory}{AppDomain.CurrentDomain.FriendlyName}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}