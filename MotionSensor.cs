using System;

namespace SmartHome{
    public class MotionSensor : Sensor
    {
        private bool isMotionDetected;

        public MotionSensor(string name) : base(name){
            isMotionDetected = false;
        }

        public void detectedMotion(){
            isMotionDetected = true;
        }

        public void reset(){
            isMotionDetected = false;
        }
    }
}
