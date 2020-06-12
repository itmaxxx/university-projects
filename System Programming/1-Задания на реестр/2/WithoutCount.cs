using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace NetCoreRegistry
{
	class RegistryList
	{
		private string Path = @"Software\MaxD\ListNoCount";

		public RegistryList(List<string> list)
		{
			SetList(list);
		}

		public void SetList(List<string> list)
		{
			try
			{
				using (RegistryKey key = Registry.CurrentUser.CreateSubKey(Path))
				{
					for (int i = 0; i < list.Count; i++)
						key.SetValue($"Item{i + 1}", list[i]);

					key.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public List<string> GetList()
		{
			var list = new List<string>();

			try
			{
				using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Path))
				{
					for (int i = 0; ; i++)
					{
						string item;

						try
						{
							item = key.GetValue($"Item{i + 1}").ToString();
						}
						catch (Exception ex)
						{
							break;
						}

						list.Add(item);
					}

					key.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return list;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			List<string> list = new List<string>()
			{
				"string1",
				"string2",
				"string3",
				"string4",
				"string5"
			};

			RegistryList RL = new RegistryList(list);

			var ListFromRegistry = RL.GetList();

			foreach (var Item in ListFromRegistry)
				Console.WriteLine(Item);
		}
	}
}