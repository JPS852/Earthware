using ConsoleApp1.Helpers;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var TestDataGenerator = new GenerateTestRows();
            
            
            SaleRow[] Test1_SalesRows = TestDataGenerator.Test1Rows();
            Receipt Test1_Receipt = new Receipt(Test1_SalesRows);
            Test1_Receipt.PrintReceipt();
            //
            //
            SaleRow[] Test2_SalesRows = TestDataGenerator.Test2Rows();
            Receipt Test2_Receipt = new Receipt(Test2_SalesRows);
            Test2_Receipt.PrintReceipt();
            //
            //
            SaleRow[] Test3_SalesRows = TestDataGenerator.Test3Rows();
            Receipt Test3_Receipt = new Receipt(Test3_SalesRows);
            Test3_Receipt.PrintReceipt();


            Console.ReadKey();
        }
    }
}
