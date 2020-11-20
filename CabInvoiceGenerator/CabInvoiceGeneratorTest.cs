using NUnit.Framework;
using CabInvoiceGenrator;

namespace CabInvoiceGenerator
{
    public class Tests
    {
        public InvoiceGenerator invoiceGenerator = null;
        /// <summary>
        /// Given distance and time should return fare
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturn_Fare()
        {
            ///Arrange
            ///Distance in kilometers
            double distance = 2.0;
            ///Time in minutes
            int time = 5;
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            ///Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            ///Assert
            Assert.AreEqual(45, fare);
        }
        /// <summary>
        /// Givens the invalid distance should throw invalid distance exception.
        /// </summary>
        //[Test]
        //public void GivenInvalidDistance_ShouldThrow_InvalidDistanceException()
        //{
        //    ///Arrange
        //    ///Distance in kilometers
        //    double distance = -10;
        //    ///Time in minutes
        //    int time = 20;
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
        //    ///Act
        //    var exception = Assert.Throws<CabInvoiceException>(() => invoiceGenerator.CalculateFare(distance, time));
        //    ///Assert
        //    Assert.AreEqual(CabInvoiceException.ExceptionType.INVALID_DISTANCE, exception.type);
        //}
        ///// <summary>
        ///// Givens the invalid time should throw invalid time exception.
        ///// </summary>
        //[Test]
        //public void GivenInvalidTime_Should_Throw_InvalidTimeException()
        //{
        //    ///Arrange
        //    ///Distance in kilometers
        //    double distance = 5;
        //    ///time in minutes
        //    int time = 0;
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
        //    ///Act
        //    var exception = Assert.Throws<CabInvoiceException>(() => invoiceGenerator.CalculateFare(distance, time));
        //    ///Assert
        //    Assert.AreEqual(CabInvoiceException.ExceptionType.INVALID_TIME, exception.type);
        //}
    }
}