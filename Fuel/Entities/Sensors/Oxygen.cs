using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fuel.Entities.Sensors
{
    internal class OxygenSensor: Sensor
    {
        public OxygenSensor(string name, string description)
                : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 40;
            Console.WriteLine($"{Name}: {Value}%");

        }


    }
}