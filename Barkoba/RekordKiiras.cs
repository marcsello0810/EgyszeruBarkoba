using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Barkoba
{
	static public class RekordKiiras
	{
		static public void rekordotkiir()
		{
			StreamReader sr = new StreamReader("Statistic.txt");
			List<Tuple<int, string>> tuples = (from line in File.ReadLines("Statistic.txt")
											   let values = line.Split(';')
											   select Tuple.Create(int.Parse(values[0]), values[1])).ToList();

			Tuple<int, string> mintuple = tuples.Min();
			sr.Close();
			Console.WriteLine("\n/"+mintuple.Item2 + "/ /" + mintuple.Item1 + "/ \n");
			Menu.opciovalasztas();
		}
	}
}
