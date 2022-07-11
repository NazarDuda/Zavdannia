using System;

namespace CarProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car newCar1 = new AudiCar("AT 1234 IP", "Q7", 350, 500000, 20000);
            Console.WriteLine(newCar1.Info());

            Car newCar2 = new AudiCar("AT 7777 NK", "RS7", 375, 200000, 100);
            Console.WriteLine(newCar2.Info());

            Car newCar3 = new AudiCar("AT 9485 MP", "R8", 450, 1000000, 5000);
            Console.WriteLine(newCar3.Info());

            Car newCar4 = new BmwCar("AT 1674 LA", "M5", 400, 600000, 1000);
            Console.WriteLine(newCar4.Info());

            Car newCar5 = new BmwCar("AT 1234 IP", "I8", 420, 75000, 22080);
            Console.WriteLine(newCar5.Info());

            Car newCar6 = new MersedesCar("AT 5673 KM", "AMG GT", 410, 250000, 35000);
            Console.WriteLine(newCar6.Info());

            Garage NewGarage = new Garage();
            NewGarage.AddCarToGarage(newCar1);
            NewGarage.ShowAllCarsInGarage();
            NewGarage.CountOfCarsByType(CarType.Bmw);
            NewGarage.CountOfCarsByType(CarType.Audi);
            NewGarage.CountOfCarsByType(CarType.Mercedes);
            NewGarage.AddCarToGarage(newCar2);
            NewGarage.AddCarToGarage(newCar3);
            NewGarage.AddCarToGarage(newCar4);
            NewGarage.AddCarToGarage(newCar5);
            NewGarage.AddCarToGarage(newCar6);
            NewGarage.ShowAllCarsInGarage();
            NewGarage.CountOfCarsByType(CarType.Bmw);
            NewGarage.CountOfCarsByType(CarType.Audi);
            NewGarage.CountOfCarsByType(CarType.Mercedes);
            NewGarage.RemoveByIdFromGarage("AT 1234 IP");
            NewGarage.RemoveByIdFromGarage("AT 7777 NK");
            NewGarage.RemoveByIdFromGarage("AT 1674 LA");
            NewGarage.ShowAllCarsInGarage();
            NewGarage.CountOfCarsByType(CarType.Bmw);
            NewGarage.CountOfCarsByType(CarType.Audi);
            NewGarage.CountOfCarsByType(CarType.Mercedes);



        }
    }
}