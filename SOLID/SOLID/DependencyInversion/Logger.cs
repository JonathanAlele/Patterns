using SOLID.DependencyInversion;
namespace SOLID.DependencyInversion
{
	public class Logger
	{
		private readonly IDataService _dataService;

		public Logger(IDataService dataService)
		{
			_dataService = dataService;
		}

		public void Log(string message)
		{
			_dataService.Save(message);
		}
	}
}