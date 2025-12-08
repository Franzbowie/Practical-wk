namespace ConsoleApp1
{
    partial class Program
    {
        class GentleSmartphone
        {
            public int SerialNumber { get; private set; }
            private TactileSensor Sensor;

            public GentleSmartphone(int serial, byte sensivity)
            {
                SerialNumber = serial;
                Sensor = new TactileSensor(sensivity);
            }
            public int GetSensivity(GentleSmartphone gentleSmartphone)
            {
                return gentleSmartphone.Sensor.Sensivity;
            }
        }
    }
}