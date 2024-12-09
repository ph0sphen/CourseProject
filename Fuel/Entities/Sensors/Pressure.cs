using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Entities.Sensors
{
    public class PressureSensor: Sensor
    {
        

        public PressureSensor (string name, string description)
            :base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble()* 3.5;
            Console.WriteLine($"{Name}: {Value} bar");

        }
        
       
    }
}