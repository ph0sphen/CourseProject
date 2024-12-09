using Fuel.Entities.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Enums
{
    namespace SensorNamespace
    {
        public enum SensorType
        {
            Temperature,
            Pressure,
            Oxygen,
            FuelLevel,
            Emissions
        }

        public class SensorModel
        {
            public SensorType Type { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Value { get; set; }

        }

        public class SensorProcessor
        {
            public void ProcessSensor(SensorModel sensor, List<SensorModel> sensors)
            {
                switch (sensor.Type)
                {
                    case SensorType.Temperature:
                        Console.WriteLine("Testing the Temperature sensor.");
                        break;

                    
                }
                switch (sensor.Type)
                {
                    case SensorType.Pressure:
                        Console.WriteLine("Testing the Pressure sensor.");
                        break;

                    
                }
                switch (sensor.Type)
                {
                    case SensorType.Oxygen:
                        Console.WriteLine("Testing the Oxygen sensor.");
                        break;

                   
                }
                switch (sensor.Type)
                {
                    case SensorType.FuelLevel:
                        Console.WriteLine("Testing the FuelLevel sensor.");
                        break;


                }
                switch (sensor.Type)
                {
                    case SensorType.Emissions:
                        Console.WriteLine("Testing the Emissions sensor.");
                        break;


                }


                var temperatureSensors = sensors.Where(s => s.Type == SensorType.Temperature).ToList();
                var pressureSensors = sensors.Where(s => s.Type == SensorType.Pressure).ToList();
                var oxygenSensors = sensors.Where(s => s.Type == SensorType.Oxygen).ToList();
                var fuelLevelSensors = sensors.Where(s => s.Type == SensorType.FuelLevel).ToList();
                var emissionsSensors = sensors.Where(s => s.Type == SensorType.Emissions).ToList();
                
            }
        }
    }
}



