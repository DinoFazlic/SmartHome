
namespace SmartHome{
    public class Blinds : SmartDevice{
        private int position;

        public Blinds(string name, int position) : base(name){
            this.position = position;
        }

        public void setPosition(int position){
            this.position = position;
        }

        public int getPosition(){
            return position;
        }

        public void open(){
            position = 100;
        }

        public void close(){
            position = 0;
        }

    }
}