using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class GoodCategory
        {
            public string Name { get; set; }
            public bool TaxExempt { get; set; }
        }

        public class Good
        {
            public string Name { get; set; }
            public GoodCategory Category { get; set; }
            public bool Imported { get; set; }
        }

        public class SaleRow
        {
            public Good Good { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }

        public class ReceiptRow
        {
            public SaleRow SaleRow { get; set; }
            public decimal RowTotal { get; set; }
            public decimal RowTax { get; set; }
        }

        public class Receipt
        {
            decimal TotalTax = 0.0m;
            decimal Total = 0.0m;

            List<ReceiptRow> Rows = new List<ReceiptRow>();

            public Receipt(SaleRow[] SaleRows)
            {
                for(int i = 0; i < SaleRows.Length; i++)
                {
                    ReceiptRow NewReceiptRow = new ReceiptRow
                    {
                        SaleRow = SaleRows[i],
                        RowTotal = SaleRows[i].Price * SaleRows[i].Quantity
                    };

                    if(!SaleRows[i].Good.Category.TaxExempt)
                    {
                        decimal RoundedVal = Math.Ceiling((NewReceiptRow.RowTotal * 0.1m) * 20m);
                        NewReceiptRow.RowTax += RoundedVal / 20m;
                    }

                    if(SaleRows[i].Good.Imported == true)
                    {
                        decimal RoundedVal = Math.Ceiling((NewReceiptRow.RowTotal * 0.05m) * 20m);
                        NewReceiptRow.RowTax += RoundedVal / 20m;
                    }

                    Total += NewReceiptRow.RowTotal;
                    TotalTax += NewReceiptRow.RowTax;

                    Rows.Add(NewReceiptRow);
                }
            }

            public void PrintReceipt()
            {
                foreach(var Row in Rows)
                {
                    Console.WriteLine(Row.SaleRow.Quantity + " " + Row.SaleRow.Good.Name + ": £" + (Row.RowTotal + Row.RowTax).ToString("0.00"));
                }

                Console.WriteLine("Sales Taxes: " + TotalTax.ToString("0.00"));
                Console.WriteLine("Total: " + (TotalTax + Total).ToString("0.00"));
            }
        }



        static void Main(string[] args)
        {
            GoodCategory[] Categories = new GoodCategory[]
            {
                new GoodCategory
                {
                    Name = "Books",
                    TaxExempt = true
                },
                new GoodCategory
                {
                    Name = "Food",
                    TaxExempt = true
                },
                new GoodCategory
                {
                    Name = "Medical",
                    TaxExempt = true
                },
                new GoodCategory
                {
                    Name = "Music",
                    TaxExempt = false
                },
                new GoodCategory
                {
                    Name = "Perfume",
                    TaxExempt = false
                }
            };

            Good[] Goods = new Good[]
            {
                new Good
                {
                    Name = "Book",

                    Category = Categories[0]
                },
                new Good
                {
                    Name = "Music CD",

                    Category = Categories[3]
                },
                new Good
                {
                    Name = "Chocolate Bar",

                    Category = Categories[1]
                },
                new Good
                {
                    Name = "Imported Box of Chocolates",

                    Category = Categories[1],
                    Imported = true
                },
                new Good
                {
                    Name = "Imported Bottle of Perfume",

                    Category = Categories[4],
                    Imported = true
                },
                new Good
                {
                    Name = "Bottle of Perfume",

                    Category = Categories[4],
                },
                new Good
                {
                    Name = "Packet of Headache Pills",

                    Category = Categories[2],
                },
            };

            SaleRow[] Test1_SalesRows = new SaleRow[]
            {
                new SaleRow
                {
                    Good = Goods[0],
                    Quantity = 1,
                    Price = 12.49m
                },
                new SaleRow
                {
                    Good = Goods[1],
                    Quantity = 1,
                    Price = 14.99m
                },
                new SaleRow
                {
                    Good = Goods[2],
                    Quantity = 1,
                    Price = 0.85m
                }
            };

            //
            //

           Receipt Test1_Receipt = new Receipt(Test1_SalesRows);
           Test1_Receipt.PrintReceipt();

            //
            //

            SaleRow[] Test2_SalesRows = new SaleRow[]
            {
                new SaleRow
                {
                    Good = Goods[3],
                    Quantity = 1,
                    Price = 10.00m
                },
                new SaleRow
                {
                    Good = Goods[4],
                    Quantity = 1,
                    Price = 47.50m
                }
            };

           Receipt Test2_Receipt = new Receipt(Test2_SalesRows);
           Test2_Receipt.PrintReceipt();

            //
            //

            SaleRow[] Test3_SalesRows = new SaleRow[]
            {
                new SaleRow
                {
                    Good = Goods[4],
                    Quantity = 1,
                    Price = 27.99m
                },
                new SaleRow
                {
                    Good = Goods[5],
                    Quantity = 1,
                    Price = 18.99m
                },
                new SaleRow
                {
                    Good = Goods[6],
                    Quantity = 1,
                    Price = 9.75m
                },
                new SaleRow
                {
                    Good = Goods[3],
                    Quantity = 1,
                    Price = 11.25m
                }
            };

            Receipt Test3_Receipt = new Receipt(Test3_SalesRows);
            Test3_Receipt.PrintReceipt();

            Console.ReadKey();

        }
    }
}
