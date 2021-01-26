using System;
using ConsoleApp1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Helpers;

namespace Tests
{
    [TestClass]
    public class SalesTaxTests
    {
        [TestMethod]
        public void TestReceipt()
        {
            var TestDataGenerator = new GenerateTestRows();

            //
            //

            SaleRow[] Test1_SalesRows = TestDataGenerator.Test1Rows();

            Receipt Test1_Receipt = new Receipt(Test1_SalesRows);
            
            if(Test1_Receipt.TotalWithTax != 29.83m)
            {
                Assert.Fail($"Test1 Receipt Total Fail, value found: {Test1_Receipt.TotalWithTax}");
            }
            if (Test1_Receipt.TotalTax != 1.5m)
            {
                Assert.Fail($"Test1 Receipt TotalTax Fail, value found: {Test1_Receipt.TotalTax}");
            }

            //
            //

            SaleRow[] Test2_SalesRows = TestDataGenerator.Test2Rows();

            Receipt Test2_Receipt = new Receipt(Test2_SalesRows);

            if (Test2_Receipt.TotalWithTax != 65.15m)
            {
                Assert.Fail($"Test2 Receipt Total Fail, value found: {Test2_Receipt.TotalWithTax}");
            }
            if (Test2_Receipt.TotalTax != 7.65m)
            {
                Assert.Fail($"Test2 Receipt TotalTax Fail, value found: {Test2_Receipt.TotalTax}");
            }

            //
            //

            SaleRow[] Test3_SalesRows = TestDataGenerator.Test3Rows();

            Receipt Test3_Receipt = new Receipt(Test3_SalesRows);

            if (Test3_Receipt.TotalWithTax != 74.68m)
            {
                Assert.Fail($"Test3 Receipt Total Fail, value found: {Test3_Receipt.TotalWithTax}");
            }
            if (Test3_Receipt.TotalTax != 6.70m)
            {
                Assert.Fail($"Test3 Receipt TotalTax Fail, value found: {Test3_Receipt.TotalTax}");
            }
        }
    }
}
