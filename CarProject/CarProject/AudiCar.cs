using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class AudiCar : Car
    {
        public AudiCar(string id, string model, int maxSpeed, int strength, int race) : base(id, model, maxSpeed, strength, race){}

        public override string Info()
        {
            return "Audi car: " + base.Info();
        }
    }
}
