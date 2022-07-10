using System;

namespace CarProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car newCar1 = new AudiCar("AT 1234 IP", "Q7", 350, 500000, 20000);
            Console.WriteLine(newCar1.Info());

            Car newCar2 = new BmwCar("AT 1674 LA", "M5", 400, 600000, 1000);
            Console.WriteLine(newCar2.Info());

            Car newCar3 = new MersedesCar("AT 5673 KM", "AMG GT", 410, 250000, 35000);
            Console.WriteLine(newCar3.Info());
        }
    }
}