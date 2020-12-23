using NUnit.Framework;
using CabInvoiceGenerator_CSharp;
namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;
        
        /// <summary>
        /// Test Case_1 Given Distance and Time The Invoice Generator Should Return TotalFare.
        /// </summary>
        
        [Test]
        public void GivenDistanceAndTimeReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator();
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}