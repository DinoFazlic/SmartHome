
namespace SmartHome{
    public abstract class Sensor{
        private string name;

        public Sensor(string name){
            this.name = name;
        }

        public string getName(){
            return name;
        }

    }
}
