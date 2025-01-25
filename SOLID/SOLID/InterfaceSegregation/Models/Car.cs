namespace InterfaceSegregation.Models
{
	public class Car : IRunner
	{
		public void Run() => Console.WriteLine("Driving");
	}
}