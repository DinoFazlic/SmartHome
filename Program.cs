using System;

namespace SmartHome{
    class Program{
        static void Main(string[] args){
            Controller controller = new Controller();

            Light livingRoomLight = new Light("LivingRoom",100);
            Thermostat thermostat = new Thermostat("Home");
            Blinds blinds = new Blinds("LivingRoom",0);
            WashingMachine washingMachine = new WashingMachine("Bathroom");

            controller.addDevice(livingRoomLight);
            controller.addDevice(thermostat);
            controller.addDevice(blinds);
            controller.addDevice(washingMachine);

            MotionSensor motionSensorLivingRoom = new MotionSensor("LivingRoom");
            TemperatureSensor temperatureSensor = new TemperatureSensor("Home"); 

            controller.addSensor(motionSensorLivingRoom);
            controller.addSensor(temperatureSensor);

            Scenario scenario = new Scenario(controller);

            motionSensorLivingRoom.detectedMotion();
            temperatureSensor.setTemperature(35);

            scenario.checkConditions();

            controller.turnOnWahingMachine("Quick wash", 50, 1200, 30); 

            

            Console.WriteLine($"Light in the living room: {(livingRoomLight.isDeviceOn() ? "ON" : "OFF")}");
            Console.WriteLine($"Termostat: {thermostat.getTemperature()} degrees");
            Console.WriteLine($"Blinds: {blinds.getPosition()}%");
        }
    }
}
