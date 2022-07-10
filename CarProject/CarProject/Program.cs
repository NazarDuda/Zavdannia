using System;

namespace CarProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car newCar = new ("AT 1234 IP", "Audi Q7", 350, 500000, 20000);
            newCar.Info();
        }
    }
}