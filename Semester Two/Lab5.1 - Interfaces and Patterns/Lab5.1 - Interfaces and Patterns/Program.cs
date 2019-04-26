using System;
using System.Collections;

namespace Lab5._1___Interfaces_and_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPark generic = new CarPark();
            


            foreach (Car a in generic)
            {
                Console.WriteLine("Car Name: " + a.getName() + "  |  Location: " + a.getLocation()+ "  |  Price: " + a.getPrice());
            }

            
        }
    }

    //This is an interface; Kind of a blueprint for a Class;
    public interface IVehicle
    {
        string getName();
        string getLocation();
        double getPrice();
    }

    //The Class inherits the blueprint; This one needs three methods, as specified in the interface;
    class Car : IVehicle
    {
        string name;
        string location;
        double price;

        public Car (string name, string location, double price)
        {
            this.name = name;
            this.location = location;
            this.price = price;

        }

        public string getName()
        {
            return name;
        }
        public string getLocation()
        {
            return location;
        }
        public double getPrice()
        {
            return price;
        }
    }

    class CarPark : IEnumerable
    {
        public Car[] cars = new Car[6];

        public CarPark()
        {
            cars[0] = new Car("Ferrari", "Section C" , 5.50 );
            cars[1] = new Car("Aston Martin", "Section F", 3.70);
            cars[2] = new Car("Lambogini", "Section C", 7.50);
            cars[3] = new Car("Ferrari Sport", "Section A", 1.10);
            cars[4] = new Car("Ford Fiesta", "Section J", 11.50);
            cars[5] = new Car("Suzuki Swift", "Section B", 8.05);
        }

        //This enumerator can iterate through all cars and their attributes;
        public IEnumerator GetEnumerator()
        {
            // Return the array object's IEnumerator.
            return cars.GetEnumerator();
        }


    }




}
