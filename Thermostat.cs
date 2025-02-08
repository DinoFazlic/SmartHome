using System;

namespace SmartHome{
    public class Thermostat : SmartDevice{
        private int temperatureLevel;

        public Thermostat(string name, int temperature) : base(name){
            temperatureLevel = temperature;
        }

        public void setTemperature(int temperature){
            temperatureLevel = temperature;
        }

        public int getTemperature(){
            return temperatureLevel;
        }

    }
}