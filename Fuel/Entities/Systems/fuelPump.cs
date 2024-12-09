using Fuel.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Entities.Systems
{
    public class fuelPump: IControllable
    {
        public bool IsOn {  get; private set;  }
        private double fuelLevel;
        public void SetFuelLevel(double fuelLevel)
        {
            this.fuelLevel = fuelLevel;
        }
        public void TurnOn()
        {
            if(fuelLevel == 0)
            {
                IsOn = true;
                Console.WriteLine("FuelPump turned on.");
            }
            
        }
        public void TurnOff()
        { 
            if(fuelLevel == 1)
            IsOn = false;
            Console.WriteLine("FuelPump turned off.");
        }
    }
}
