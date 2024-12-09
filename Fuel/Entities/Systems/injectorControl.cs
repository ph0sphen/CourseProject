using Fuel.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Entities.Systems
{
    public class injectorControl: IControllable
    {
    public bool IsOn { get; private set; }
        private double oxygenLevel;

    public void TurnOn()
    {
            
                IsOn = oxygenLevel <40;
                Console.WriteLine($"Injector is {(IsOn ? "active" : "inactive")}");
           
    
    }
    public void TurnOff()
    {
            if (oxygenLevel == 40) 
            {
                IsOn = false;
                Console.WriteLine("Injector turned off.");
            }
              
    }
}
}