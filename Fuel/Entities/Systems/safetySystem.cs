using Fuel.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Entities.Systems
{
    public  class safetySystem: IControllable
    {
        public bool IsEmergency { get; private set; }
        private double emissions;
        private double temperature;
        public void TurnOn()
        {
            IsEmergency = true;
            Console.WriteLine("Safety system turned on.");
        }
        public void TurnOff()
        {
            IsEmergency = emissions > 80 || temperature > 90;
            Console.WriteLine(IsEmergency ? "Emergency shutdown initiated!" : "System is operating normally.");
                    }
    }
}