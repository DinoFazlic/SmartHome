using System;

namespace SmartHome{
    public class WashingMachine : SmartDevice{

        private string mode;
        private int temperatureLevel;
        private int speed;
        private int time;
        private bool isWashing;

        public WashingMachine( string name, string mode, int temperature, int speed, int time) : base(name){
            this.mode = mode;
            temperatureLevel = temperature;
            this.speed = speed;
            this.time = time;
            isWashing = false;
        }

        public void setMode(string mode){
            this.mode = mode;
            Console.WriteLine("Mode set to +" + mode + ".");
        }

        public string getMode(){
            return mode;
        }

        public void setTemperature(int temperature){
            temperatureLevel = temperature;
            Console.WriteLine("Temperature set to" + temperature + " degrees.");
        }

        public int getTemperature(){
            return temperatureLevel;
        }

        public void setSpeed(int speed){
            this.speed = speed;
            Console.WriteLine("Spin speed set to" + speed + " rpm.");
        }

        public int getSpeed(){
            return speed;
        }

        public void setTime(int newTime)
        {
            time = newTime;
            Console.WriteLine("Time set to" + time + " minutes.");
        }


        public void startWashing(){
            isWashing = true;
        }

         public void stopWashing(){
            isWashing = false;
        }


        
    }
}