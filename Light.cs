
namespace SmartHome{
    public class Light : SmartDevice{
        private int brightnessLevel;

        public Light(string name, int brightness) : base(name){
            brightnessLevel = brightness;
        }

        public void setBrightness(int brightness){
            brightnessLevel = brightness;
        }

        public int getBrightness(){
            return brightnessLevel;
        }

    }
}