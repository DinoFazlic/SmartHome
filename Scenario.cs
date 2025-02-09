
namespace SmartHome{
    public class Scenario{
        private List<Sensor> sensors;
        private bool conditionMet;
        private Controller controller;

        public Scenario(Controller controller){
            sensors = controller.getSensors();
            this.conditionMet = false;
            this.controller = controller;
        }

        public void checkConditions(){

            foreach (Sensor sensor in sensors){
                if (sensor is MotionSensor motionSensor && motionSensor.isMotionDetected()){
                    this.conditionMet = true;
                    executeScenario();
                    break;
                }
                if (sensor is TemperatureSensor tempSensor && tempSensor.getTemperature() <= 5){
                    this.conditionMet = true;
                    executeScenario();
                    break;
                }
                if (sensor is TemperatureSensor tSensor && tSensor.getTemperature() > 30){
                    this.conditionMet = true;
                    executeScenario();
                    break;
                }
                
            }
        }

        public void executeScenario(){
            if (conditionMet){

                foreach (Sensor sensor in sensors){
                    if (sensor is TemperatureSensor tempSensor && tempSensor.getTemperature() <= 5){
                        Console.WriteLine("Setting thermostat to 20 degrees.");
                        controller.turnOnThermostat(20);
                        tempSensor.setTemperature(20);
                    }
                    if(sensor is TemperatureSensor tSensor && tSensor.getTemperature() > 30){
                        Console.WriteLine("Setting thermostat to 20 degrees and closing the blinds.");
                        controller.turnOnThermostat(20);
                        controller.setBlinds(50);
                    }
                    if (sensor is MotionSensor motionSensor && motionSensor.isMotionDetected()){
                        string sensorName = motionSensor.getName();
                        controller.turnOnLights(sensorName);
                        Console.WriteLine("Scenario motion detected in " + sensorName + ".");
                    }
                }

            }
        }
    }
}
