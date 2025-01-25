using System;
using SOLID.OpenClosed;
namespace SOLID.OpenClosed.Repositories
{
	public class FileInvoiceRepository : IInvoiceRepository
	{
		public void Save(Invoice invoice)
		{
			Console.WriteLine($"Saving the invoice #{invoice.InvoiceNo} into a file");
		}
	}
}