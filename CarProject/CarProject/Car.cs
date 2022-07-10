using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    abstract class Car
    {
        protected string Id;
        protected string Model;
        protected int MaxSpeed;
        protected int Strength;
        protected int Race;

        public Car(string id, string model, int maxSpeed, int strength, int race)
        {
            Id = id;
            Model = model;
            MaxSpeed = maxSpeed;
            Strength = strength;
            Race = race;
        }

        public virtual string Info() =>
            $"Id = {Id}, Model = {Model}, MaxSpeed = {MaxSpeed}, Strength = {Strength}, Race = {Race} ";

    }
}
