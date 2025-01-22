using System;

public class InvoiceRepository
{
	public void Save(Invoice invoice)
	{
		Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo}");
	}
}
