﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public enum CarType
    {
        Bmw,
        Audi,
        Mercedes
    }

    public class Garage
    {
        private List<Car> ListOfCars;

        private Dictionary<CarType, int> CountOfCars; 

        public Garage()
        {
            ListOfCars = new List<Car>();
            CountOfCars = new Dictionary<CarType, int>();
            CountOfCars.Add(CarType.Bmw, 0);
            CountOfCars.Add(CarType.Audi, 0);
            CountOfCars.Add(CarType.Mercedes, 0);
        }
        
        public  void AddCar(Car car)
        {
            ListOfCars.Add(car);

            CarType type = car.GetType();
            if(type == CarType.Bmw)
            {
                CountOfCars[CarType.Bmw] += 1;
            }

            else if(type == CarType.Audi)
            {
                CountOfCars[CarType.Audi] += 1;
            }

            else if(type == CarType.Mercedes)
            {
                CountOfCars[CarType.Mercedes] += 1;
            }   
        }

        public  void RemoveById(string IdOfCar)
        {
            var car = ListOfCars.Where(x => x.GetId() == IdOfCar).First();
            ListOfCars.Remove(car); 

            CarType type = car.GetType();
            if (type == CarType.Bmw)
            {
                CountOfCars[CarType.Bmw] -= 1;
            }

            else if (type == CarType.Audi)
            {
                CountOfCars[CarType.Audi] -= 1;
            }

            else if (type == CarType.Mercedes)
            {
                CountOfCars[CarType.Mercedes] -= 1;
            }
        }

        public  void CountOfCarsByType(CarType type)
        {
                Console.WriteLine($"Count of BmwCars = {CountOfCars[type]}");
        }

        public  void ShowAllCars()
        {
            foreach (var car in ListOfCars)
            {
                Console.WriteLine(car.Info());
            }  
        }
    }
}
