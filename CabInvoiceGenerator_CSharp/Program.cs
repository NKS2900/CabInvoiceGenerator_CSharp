using System;

namespace CabInvoiceGenerator_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***CabInvioceGenerator***");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");
        }
    }
}
