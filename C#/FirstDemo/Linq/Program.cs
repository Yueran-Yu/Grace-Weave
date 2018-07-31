using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>(){
                new Car {Make = "Oldsmobile", Model = "Cutlas Supreme", VIN="E5", StickPrice = 55000,Year = 2009},
                new Car {Make = "Nissan",Model = "Altima", VIN = "F6", StickPrice =35000, Year=2010},
                new Car {Make = "BMW", Model = "750li", VIN = "C3",StickPrice = 75000, Year=2008},
                new Car {Make = "Ford",Model = "Escape", VIN = "D4",StickPrice = 85000, Year = 2010},
                new Car {Make = "BMW",Model = "Escapest", VIN = "F4",StickPrice = 25000, Year = 2010}

            };


            //LinQ query
            //var bmws = from car in myCars
            //where car.Make == "BMW"
            // && car.Year == 2010
            //select car;

            //var orderedCars = from car in myCars
            //orderby car.Year descending
            //select car;


            //LinQ method
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); 

            //var orderedCars = myCars.OrderByDescending(x => x.Year);

            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{1} {0} ", car.Make, car.Year);
            //}


            //var firstBMW = myCars.OrderByDescending( x=> x.Year).First(x => x.Make == "BMW");
            //Console.WriteLine(firstBMW.Model);

            //Console.WriteLine(myCars.TrueForAll(x => x.Year > 1999));

            //myCars.ForEach(x => x.StickPrice -= 3000);
            //myCars.ForEach(x => Console.WriteLine("{0} {1:C}", x.VIN, x.StickPrice));

            //Console.WriteLine(myCars.Exists(x => x.Model == "750li"));
            //Console.WriteLine(myCars.Sum(x => x.StickPrice));

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(x => x.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(x => x.Make == "BMW" && x.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var newCars = from vehicle in myCars
               where vehicle.Make == "BMW"
               && vehicle.Year == 2010
               select new {vehicle.Make, vehicle.Model};
            Console.WriteLine(newCars.GetType());

        }
    }
        class Car
        {
            public string Make { get; set; }
            public string VIN { get; set; }
            public string Model { get; set; }
            public int StickPrice { get; set; }
            public int Year { get; set; }
        }

    }
