using System;

namespace SmartHome{
    public class TemperatureSensor : Sensor{
        private int currentTemperature;

        public TemperatureSensor(string name) : base(name){
            currentTemperature = 0;
        }

        public void setTemperature(int newTemperature){
            currentTemperature = newTemperature;
        }

         public int getTemperature(){
            return currentTemperature;
        }

        public void checkTemperature(Thermostat thermostat)
        {
            if (currentTemperature <= 5){
                thermostat.turnOn();
                thermostat.setTemperature(20);
                currentTemperature = 20;
            }
        }
    }
}
