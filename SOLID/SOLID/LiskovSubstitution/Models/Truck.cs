namespace LiskovSubstitution.Models
{
	public class Truck : Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("Driving a truck");
		}
	}
}