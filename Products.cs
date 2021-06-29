using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public abstract class Product

    {

        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double Quantity { get; set; }

        public abstract void Display(string currentdate);

    }

    public class Food : Product
    {
        public string Date { get; set; }
        public Food(double quantity,string name,string brand,double price,string date)
        {
            this.Quantity = quantity;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Date = date;
        }
        public override void Display(string currentdate)
        {
            DateTime currentdatetime = Methods.ConverToDateTime(currentdate);
            DateTime datetime = Methods.ConverToDateTime(Date);
            Console.WriteLine(Name+" - "+Brand);
            Console.WriteLine(Quantity +" x  $"+ Price+" = $"+ Math.Round(Quantity *Price,2,MidpointRounding.AwayFromZero));
            if ((datetime - currentdatetime).TotalDays <= 1)
            {
                this.Discount = (Price * Quantity) / 2;
                Console.WriteLine("#discount 50% -$" + Math.Round(Discount, 2, MidpointRounding.AwayFromZero));
            }
            else if ((datetime - currentdatetime).TotalDays <= 5)
            {
                this.Discount = (Price * Quantity) / 10;
                Console.WriteLine("#discount 10% -$" + Math.Round(Discount, 2, MidpointRounding.AwayFromZero));
            }
            else this.Discount =0;

        }
    }
    public class Bevarage : Product
    {
        public string Date { get; set; }
        public Bevarage(double quantity, string name, string brand, double price, string date)
        {
            this.Quantity = quantity;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Date = date;
        }
        public override void Display(string currentdate)
        {
            DateTime currentdatetime = Methods.ConverToDateTime(currentdate);
            DateTime datetime = Methods.ConverToDateTime(Date);
            Console.WriteLine(Name + " - " + Brand);
            Console.WriteLine(Quantity + " x $" + Price+" = $" + Math.Round(Quantity * Price, 2, MidpointRounding.AwayFromZero));
            this.Discount = (Price * Quantity) / 2;
            if ((datetime - currentdatetime).TotalDays <= 1)
            {
                this.Discount = (Price * Quantity) / 2;
                Console.WriteLine("#discount 50% -$" + Math.Round(Discount, 2, MidpointRounding.AwayFromZero));
            }
            else if ((datetime - currentdatetime).TotalDays <= 5)
            {
                this.Discount = (Price * Quantity) / 10;
                Console.WriteLine("#discount 10% -$" + Math.Round(Discount, 2, MidpointRounding.AwayFromZero));
            }
            else this.Discount = 0;

        }
    }
    public class Clothes : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public Clothes(double quantity, string name, string brand, double price, string size, string color)
        {
            this.Quantity = quantity;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Size = size;
            this.Color = color;
        }
        public override void Display(string currentdate)
        {
            DateTime currentdatetime = Methods.ConverToDateTime(currentdate);
            Console.WriteLine(Name + " " + Brand + " " + Size + " " + Color);
            Console.WriteLine(Quantity + " x $" + Price + " = $" + Math.Round(Quantity * Price, 2, MidpointRounding.AwayFromZero));
            if (currentdatetime.DayOfWeek == DayOfWeek.Monday ||
               currentdatetime.DayOfWeek == DayOfWeek.Tuesday ||
               currentdatetime.DayOfWeek == DayOfWeek.Wednesday ||
               currentdatetime.DayOfWeek == DayOfWeek.Thursday ||
               currentdatetime.DayOfWeek == DayOfWeek.Friday)
            {
                this.Discount = Math.Round(Price * Quantity / 10, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("#discount 10% -$" + Discount);
            }
            else this.Discount = 0;

        }
    }

    public class Appliance : Product
    {
        public string Model { get; set; }
        public string Date { get; set; }
        public double Weight { get; set; }
        public Appliance(double quantity, string name, string brand, double price, string date,string model,double weight)
        {
            this.Quantity = quantity;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Date = date;
            this.Model = model;
            this.Weight = weight;
        }
        public override void Display(string currentdate)
        {
            DateTime currentdatetime = Methods.ConverToDateTime(currentdate);
            Console.WriteLine(Name + " " + Brand + " " + Model);
            Console.WriteLine(Quantity + " x $" + Price + " = $" + Math.Round(Quantity * Price, 2, MidpointRounding.AwayFromZero));
            if ((currentdatetime.DayOfWeek == DayOfWeek.Saturday || currentdatetime.DayOfWeek == DayOfWeek.Sunday) 
                &&
                Price>=999)
            {
                this.Discount = Math.Round(Price * Quantity / 20, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("#discount 10% -$" + Discount);
            }
            else this.Discount = 0;

        }

    }


}
