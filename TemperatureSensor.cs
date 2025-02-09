
namespace SmartHome{
    public class TemperatureSensor : Sensor{
        private int currentTemperature;

        public TemperatureSensor(string name) : base(name){
            currentTemperature = new Random().Next(-5, 36);
        }

        public void setTemperature(int newTemperature){
            currentTemperature = newTemperature;
        }

        public int getTemperature(){
            return currentTemperature;
        }

    }
}
