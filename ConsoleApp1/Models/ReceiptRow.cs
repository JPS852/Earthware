using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ReceiptRow
    {
        public SaleRow SaleRow { get; set; }
        public decimal RowTotal { get; set; }
        public decimal RowTax { get; set; }
    }
}
