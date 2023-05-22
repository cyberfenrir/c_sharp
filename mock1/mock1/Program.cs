using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;


namespace mock1
{
   
    public class Car {

        public string Model { get; set; }

        public string BodyStyle { get; set; }

        public double Price { get; set; }

        public Car() { }

        public Car(string model, string bodyStyle, double price)
        {
            this.BodyStyle = bodyStyle;
            this.Price = price;
            this.Model = model;
        }

        public Car(string model) {
            this.Model = model;
        }


    }

    public class CarUtility : Car {

        public CarUtility() { }

        public CarUtility(string model) : base(model) {
        
            this.Model = model;
        
        }

        public bool ValidateCarModel(string model) {
            if ((model == "A3") || (model == "A8") || (model == "Q5")) {
                return true;
            }
            return false;
        }

        public Car PriceCalculation() {



            if (BodyStyle == "Sedan") {
                this.Price = Price - Price * 0.05;
            }

            else if (BodyStyle == "SUV")
            {
                this.Price = Price - Price * 0.1;
            }

            return new Car(Model, BodyStyle, Price);
        }
    
    }
    public class Program
    {
        public static void Main(string[] args) {

        CarUtility cu = new CarUtility();
        //string m1, b1;
        //double p1;
        Console.WriteLine("Enter the model");
        cu.Model = Console.ReadLine();

        bool temp = cu.ValidateCarModel(cu.Model);

        if (temp)
        {
            Console.WriteLine("Enter the body style");
            cu.BodyStyle = Console.ReadLine();

            Console.WriteLine("Enter the price");
            cu.Price = double.Parse(Console.ReadLine());

            _ = cu.PriceCalculation();

            Console.WriteLine($"Model: {cu.Model} \nBody Style: {cu.BodyStyle} \nPrice After Discount: {cu.Price}");
        }
        
        else {

            Console.WriteLine("Invalid car model");
        
        }




    }
}
}