using System;

namespace SmartHome{
    public class MotionSensor : Sensor
    {
        private bool motion;

        public MotionSensor(string name) : base(name){
            motion = false;
        }

        public void detectedMotion(){
            motion = true;
        }

        public bool isMotionDetected(){
            return motion;
        }

        public void reset(){
            motion = false;
        }
    }
}
