
namespace SmartHome{
    public class Controller{
        private List<SmartDevice> devices;
        private List<Sensor> sensors;

        public Controller(){
            devices = new List<SmartDevice>();
            sensors = new List<Sensor>();
        }

        public List<Sensor> getSensors(){
            return sensors;
        }

        public void addDevice(SmartDevice device){
            devices.Add(device);
        }

        public void addSensor(Sensor sensor){
            sensors.Add(sensor);
        }

        

        public void turnOnLights(string roomName){
            foreach (SmartDevice device in devices){
                if (device is Light light  && light.getName().Contains(roomName)){
                    light.turnOn();
                }
            }
        }

        public void turnOffLights(string roomName){
            foreach (SmartDevice device in devices){
                if (device is Light light  && light.getName().Contains(roomName)){
                    light.turnOff();
                }
            }
        }

        public void turnOnThermostat(int temperature){
            foreach (SmartDevice device in devices){
                if (device is Thermostat thermostat){
                    thermostat.turnOn();
                    thermostat.setTemperature(temperature);
                }
            }
        }

        public void turnOffThermostat(){
            foreach (SmartDevice device in devices){
                if (device is Thermostat thermostat){
                    thermostat.turnOff();
                }
            }
        }

        public void turnOffAllDevices(){
            foreach (SmartDevice device in devices){
                device.turnOff();
            }
        }

        public void turnOnAllDevices(){
            foreach (SmartDevice device in devices){
                device.turnOn();
            }
        }

        public void turnOnWahingMachine(string mode, int temperature, int speed, int time){
            foreach (SmartDevice device in devices){
                if (device is WashingMachine washingMachine){
                    washingMachine.startWashing(mode, temperature, speed, time);
                }
            }
        }

        public void turnOffWashingMachine(){
            foreach (SmartDevice device in devices){
                if (device is WashingMachine washingMachine){
                    washingMachine.stopWashing();
                }
            }
        }

        public void openBlinds(){
            foreach (SmartDevice device in devices){
                if (device is Blinds blinds){
                    blinds.open();
                }
            }
        }

        public void closeBlinds(){
            foreach (SmartDevice device in devices){
                if (device is Blinds blinds){
                    blinds.close();
                }
            }
        }

        public void setBlinds(int position){
            foreach (SmartDevice device in devices){
                if (device is Blinds blinds){
                    blinds.setPosition(position);
                }
            }
        }

       
    }
}
