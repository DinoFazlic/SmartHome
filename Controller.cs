using System;
using System.Collections.Generic;

namespace SmartHome{
    public class Controller{
        private List<SmartDevice> devices;
        private List<Sensor> sensors;

        public Controller(){
            devices = new List<SmartDevice>();
            sensors = new List<Sensor>();
        }

        public void addDevice(SmartDevice device){
            devices.Add(device);
        }

        public void addSensor(Sensor sensor){
            sensors.Add(sensor);
        }

        public void checkSensors(){
            foreach (Sensor sensor in sensors){
                if (sensor is MotionSensor motionSensor){
                    if (motionSensor.isMotionDetected()){
                        string sensorName = motionSensor.getName();
                        turnOnLights(sensorName);
                        Console.WriteLine("Motion detected in " + sensorName);
                        Console.WriteLine(sensorName + " lights turned on");
                    }
                }
                else if (sensor is TemperatureSensor tempSensor){
                    double currentTemp = tempSensor.getTemperature();
                    Console.WriteLine("Current temperature: " + currentTemp);
        
                    if (currentTemp <= 5){
                        turnOnThermostat(15);
                        tempSensor.setTemperature(15);
                    } 
                }
            }
        }

        private void turnOnLights(string roomName){
            foreach (SmartDevice device in devices){
                if (device is Light light  && light.getName().Contains(roomName)){
                    light.turnOn();
                }
            }
        }

        private void turnOnThermostat(int temperature){
            foreach (SmartDevice device in devices){
                if (device is Thermostat thermostat){
                    thermostat.turnOn();
                    thermostat.setTemperature(temperature);
                }
            }
        }
    }
}
