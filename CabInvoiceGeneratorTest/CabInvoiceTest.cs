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

        /// <summary>
        /// Test Case_2 The InvoiceSummery Should Return Total Fare InvoiceSummary for multiple Rides.
        /// </summary>
        [Test]
        public void GivenMultipleRides_UsingInvoiceSummary_ShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);
            Assert.AreEqual(expectedSummary, summary);
        }

        /// <summary>
        /// Test Case_3 The InvoiceGenerator should now return The Enhanced Invoice.
        /// Total no. of Rides,TotalFare,AverageFarePerRide
        /// </summary>
        [Test]
        public void GivenInvoiceGenerator_UsingInvoiceSummary_ShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0, 3);
            Assert.AreEqual(expectedSummary, summary);
        }

    }
}