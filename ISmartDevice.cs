using System;

namespace SmartHome{
    public interface ISmartDevice{
        string getName();
        void turnOn();
        void turnOff();
    }
}