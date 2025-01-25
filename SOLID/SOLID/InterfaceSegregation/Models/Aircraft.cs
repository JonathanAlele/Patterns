using InterfaceSegregation;
using System;
namespace InterfaceSegregation.Models
{
	public class Aircraft : IRunner, IFlyable
	{
		public void Run() => Console.WriteLine("Driving");
		public void Fly() => Console.WriteLine("Flying");
	}
}