using System;

namespace SOLID.DependencyInversion
{
	public class DatabaseService: IDataService 
	{
		public void Save(string data)
		{
			Console.WriteLine("Save the message into the database");
		}
	}
}