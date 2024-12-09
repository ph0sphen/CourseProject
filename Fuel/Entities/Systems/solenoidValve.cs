using Fuel.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Entities.Systems
{
    public  class solenoidValve: IControllable
    {
        public bool IsOn { get; private set; }
        private double pressure;
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Valve is Open.");
        }
        public void TurnOff()
        {
            if (pressure > 5)
            {
                IsOn = false;
                Console.WriteLine("Valve turned is Closed.");
            }
                
        }
        public void OnOff() { IsOn = false;}
    }
}