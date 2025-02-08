using System;

namespace SmartHome{
    class Program{
        static void Main(string[] args){
            Thermostat thermostat = new Thermostat("Living Room");
            TemperatureSensor temperatureSensor = new TemperatureSensor("Living Room Temperature Sensor"); 

            temperatureSensor.setTemperature(6);
            temperatureSensor.checkTemperature(thermostat);
            Console.WriteLine(temperatureSensor.getTemperature());
        }
    }
}
