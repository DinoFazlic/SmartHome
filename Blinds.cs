using System;

namespace SmartHome{
    public class Blinds : SmartDevice{
        private int position;

        public Blinds(string name, int position) : base(name){
            this.position = position;
        }

        public void setPosition(int position){
            this.position = position;
        }

        public int getPosition(int position){
            return position;
        }

         public void Open(){
            position = 100;
        }

        public void Close(){
            position = 0;
        }

    }
}