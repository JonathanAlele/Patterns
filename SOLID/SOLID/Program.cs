//using LiskovSubstitution.Models;
//using InterfaceSegregation;
using InterfaceSegregation.Models;
using SOLID.DependencyInversion;
/*
 static void TestDrive(Vehicle vehicle)
{
	vehicle.Drive();
}

var car = new Car();
TestDrive(car);

var truck = new Truck();
TestDrive(truck);
*/

/*
var aircraft = new Aircraft();
aircraft.Run();
aircraft.Fly();


var car = new Car();
car.Run();
*/

var logger = new Logger(new DatabaseService());
logger.Log("Hello, World!");

