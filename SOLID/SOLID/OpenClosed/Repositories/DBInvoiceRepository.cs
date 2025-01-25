using SOLID.OpenClosed;
namespace SOLID.OpenClosed.Repositories
{
	public class DBInvoiceRepository : IInvoiceRepository
	{
		public void Save(Invoice invoice)
		{
			Console.WriteLine($"Saving the invoice #{invoice.InvoiceNo} into a database");
		}
	}
}