using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Helpers
{
    public class GenerateTestData
    {
        public static GoodCategory[] GetCategories()
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

            return Categories;
        }

        public static Good[] GetGoods(GoodCategory[] Categories)
        {
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

            return Goods;
        }
    }
}
