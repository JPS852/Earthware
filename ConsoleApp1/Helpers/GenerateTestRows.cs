using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Helpers
{
    public class GenerateTestRows
    {
        GoodCategory[] Categories;
        Good[] Goods;

        public GenerateTestRows()
        {
            Categories = GenerateTestData.GetCategories();
            Goods = GenerateTestData.GetGoods(Categories);
        }

        public SaleRow[] Test1Rows()
        {
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

            return Test1_SalesRows;
        }

        public SaleRow[] Test2Rows()
        {
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

            return Test2_SalesRows;
        }

        public SaleRow[] Test3Rows()
        {
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

            return Test3_SalesRows;
        }

    }
}
