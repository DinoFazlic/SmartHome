using System;

namespace SmartHome{
    public class WashingMachine : SmartDevice{

        private string mode;
        private int temperature;
        private int speed;
        private int time;

        public WashingMachine(string name) : base(name){
            isOn= false;
            time = 0;
            speed = 0;
            temperature = 0;
            mode = "";
        }

        public void setMode(string mode){
            this.mode = mode;
            Console.WriteLine("Mode set to +" + mode + ".");
        }

        public string getMode(){
            return mode;
        }

        public void setTemperature(int temperature){
            this.temperature = temperature;
            Console.WriteLine("Temperature set to" + temperature + " degrees.");
        }

        public int getTemperature(){
            return temperature;
        }

        public void setSpeed(int speed){
            this.speed = speed;
            Console.WriteLine("Spin speed set to" + speed + " rpm.");
        }

        public int getSpeed(){
            return speed;
        }

        public void setTime(int newTime){
            time = newTime;
            Console.WriteLine("Time set to" + time + " minutes.");
        }


        public void startWashing(string mode, int temperature, int speed, int time){
            Console.WriteLine("The washing machine is active.");
            isOn = true;
            this.mode = mode;
            this.temperature = temperature; 
            this.speed = speed;
            this.time = time;
        }

        public void stopWashing(){
            Console.WriteLine("The washing machine is not active.");
            isOn= false;
            time = 0;
            speed = 0;
            temperature = 0;
            mode = "";
        }


        
    }
}