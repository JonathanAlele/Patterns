namespace LiskovSubstitution.Models
{
	public class Car : Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("Driving a car");
		}
	}
}