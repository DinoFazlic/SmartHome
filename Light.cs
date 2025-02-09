
namespace SmartHome{
    public class Light : SmartDevice{
        private int brightnessLevel;

        public Light(string name) : base(name){
            brightnessLevel = 100;
        }

        public void setBrightness(int brightness){
            brightnessLevel = brightness;
        }

        public int getBrightness(){
            return brightnessLevel;
        }

    }
}