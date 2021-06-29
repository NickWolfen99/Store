using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Store
{
    class Methods
    {
        static List<Product> ProductsList = new List<Product>();

        public static void AddProducts()
        {
            ProductsList.Add(new Food(2.45,"apple", "BrandA", 1.50, "2021-06-14"));
            ProductsList.Add(new Bevarage(3,"Cider","BrandB",0.99, "2022-02-02"));
            ProductsList.Add(new Clothes(2,"Shirt", "BrandC", 15.99, "XL", "Red"));
            ProductsList.Add(new Appliance(1,"Laptop", "Asus", 2345, "2021-03-03", "VivaBook", 2.0));
        }
        public static void Receipt(string currentdate)
        {
            Show(currentdate);
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            FinalPrice(currentdate);
        }
        public static void Show(string date)
        {
            foreach (var product in ProductsList)
            {
                product.Display(date);
                Console.WriteLine();
            }
        }
        public static void FinalPrice(string currentdate)
        {
            
            double finalprice = 0;
            double discount = 0;
            foreach (var product in ProductsList)
            { 
                finalprice = finalprice + (product.Price * product.Quantity);
                discount = discount + product.Discount;
            }
            Console.WriteLine("SUBTOTAL: $"+Math.Round(finalprice, 2,MidpointRounding.AwayFromZero));
            Console.WriteLine("DISCOUNT: -$" + Math.Round(discount, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine();
            Console.WriteLine("SUBTOTAL: $"+ (Math.Round(finalprice, 2, MidpointRounding.AwayFromZero)- Math.Round(discount, 2, MidpointRounding.AwayFromZero)));

            // return finalprice;

        }
        public static DateTime ConverToDateTime(string date)
        {
            Char[] spearator = {'-'};
            Int32 count = 3;
            String[] strlist = date.Split(spearator, count,StringSplitOptions.RemoveEmptyEntries);
            int year = Int16.Parse(strlist[0]);
            int month = Int16.Parse(strlist[1]);
            int day = Int16.Parse(strlist[2]);
            DateTime datetime = new DateTime(year,month, day);
            string pattern = "yyyy-MM-dd";
            DateTime parsedDate;
            DateTime.TryParseExact(date, pattern, null,DateTimeStyles.None, out parsedDate);
            return datetime;

        }
    }
}
