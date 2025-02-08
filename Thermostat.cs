using System;

namespace SmartHome{
    public class Thermostat : SmartDevice{
        private int temperatureLevel;

        public Thermostat(string name) : base(name){
            temperatureLevel = 20;
        }

        public void setTemperature(int temperature){
            temperatureLevel = temperature;
        }

        public int getTemperature(){
            return temperatureLevel;
        }

    }
}