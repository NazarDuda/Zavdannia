using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class AudiCar : Car
    {
        public AudiCar(string id, string model, int maxSpeed, int strength, int race) : base(id, model, maxSpeed, strength, race){}

        public override string Info() =>
            "Audi car: " + base.Info();

        public override CarType GetType() =>
            CarType.Audi;
    }
}
