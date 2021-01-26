using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class SaleRow
    {
        public Good Good { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
