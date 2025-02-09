
namespace SmartHome{
    public abstract class SmartDevice : ISmartDevice{
        public string name;
        public bool isOn;

        public SmartDevice(string name){
            this.name = name;
            isOn = false;
        }

        public string getName(){
            return name;
        }

        public void setName(string name){
            this.name = name;
        }

        public void turnOn(){
            isOn = true;
        }

        public void turnOff(){
            isOn = false;
        }

        public bool isDeviceOn(){
            return isOn;
        }
    }
}