using System;

namespace Understanding_Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            //myCar.Make = "abc";
            //myCar.Model = "1234T";
            //myCar.Year = 1990;
            //  myCar.Color = "Red";
            Console.WriteLine("{0} {1} {2} {3}",
                              myCar.Make,
                              myCar.Model,
                              myCar.Year,
                              myCar.Color);

            Car my3Car = new Car("qwe", "hjs", 1998, "eu");

            //Console.WriteLine("{0:C}",myCar.DetermineMarketValue());
            Console.ReadLine();

            
            //decimal value = DetermineMarkValue(myCar);
            //Console.WriteLine("{0:c}", value);
        }
        //private static decimal DetermineMarkValue(Car car){
        //    decimal carValue = 100.0M;
        //    Console.WriteLine("JUst test!");
        //    return ++carValue; 
        //}
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int  Year { get; set; }
        public string Color { get; set; }


        public Car(){
            Make = "Nissan";
        }



        public Car(string make, string model, int year, string color){
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod(){
            Console.WriteLine("The twice method.");
            //Console.WriteLine(Make);
        }



        public decimal DetermineMarketValue(){
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }
    }
}
