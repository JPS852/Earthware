using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Receipt
    {
        private List<ReceiptRow> Rows = new List<ReceiptRow>();
        private decimal Total = 0.0m;
        public readonly decimal TotalWithTax = 0.0m;
        public readonly decimal TotalTax = 0.0m;

        public Receipt(SaleRow[] SaleRows)
        {
            for (int i = 0; i < SaleRows.Length; i++)
            {
                ReceiptRow NewReceiptRow = new ReceiptRow
                {
                    SaleRow = SaleRows[i],
                    RowTotal = SaleRows[i].Price * SaleRows[i].Quantity
                };

                if (!SaleRows[i].Good.Category.TaxExempt)
                {
                    decimal RoundedVal = Math.Ceiling((NewReceiptRow.RowTotal * 0.1m) * 20m);
                    NewReceiptRow.RowTax += RoundedVal / 20m;
                }

                if (SaleRows[i].Good.Imported)
                {
                    decimal RoundedVal = Math.Ceiling((NewReceiptRow.RowTotal * 0.05m) * 20m);
                    NewReceiptRow.RowTax += RoundedVal / 20m;
                }

                Total += NewReceiptRow.RowTotal;
                TotalTax += NewReceiptRow.RowTax;
                TotalWithTax = Total + TotalTax;

                Rows.Add(NewReceiptRow);
            }
        }

        public void PrintReceipt()
        {
            foreach (var Row in Rows)
            {
                Console.WriteLine($"{Row.SaleRow.Quantity} {Row.SaleRow.Good.Name}: £ {Row.RowTotal + Row.RowTax:0.00}");
            }

            Console.WriteLine($"Sales Taxes: {TotalTax:0.00}");
            Console.WriteLine($"Total: {TotalWithTax:0.00}");
        }
    }
}
