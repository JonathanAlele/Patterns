using LiskovSubstitution.Models;

 static void TestDrive(Vehicle vehicle)
{
	vehicle.Drive();
}

var car = new Car();
TestDrive(car);

var truck = new Truck();
TestDrive(truck);

