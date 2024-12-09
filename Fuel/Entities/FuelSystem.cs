using Fuel.Entities.Sensors;
using Fuel.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel
{
    public class FuelSystem
    {
       
        public List<Sensor> Sensors { get; set; }
        public fuelPump Pump { get; set; }
        public injectorControl Injector { get; set; }
        public solenoidValve Valve { get; set; }
        public safetySystem SafetySystem { get; set; }      
        
        public FuelSystem()
        {
            Sensors = new List<Sensor>();
            Pump = new fuelPump();
            Injector = new injectorControl();
            Valve = new solenoidValve();
            SafetySystem = new safetySystem();
        }
        public void Monitor()
        {
            foreach (var  sensor in Sensors) 
            {
                sensor.ReadValue();
            }
        }

    }

}
