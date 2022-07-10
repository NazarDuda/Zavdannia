using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class BmwCar : Car
    {
        public BmwCar(string id, string model, int maxSpeed, int strength, int race) : base(id, model, maxSpeed, strength, race){}

        public override string Info() =>
            "Bmw car: " + base.Info();

        public override CarType GetType() =>
            CarType.Bmw;
    }
}
