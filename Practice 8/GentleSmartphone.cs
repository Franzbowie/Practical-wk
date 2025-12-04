namespace ConsoleApp1
{
    partial class Program
    {
        class GentleSmartphone
        {
            public int SerialNumber { get; private set; }
            public TactileSensor Sensor { get; private set; }

            public GentleSmartphone(int serial, byte sensivity)
            {
                SerialNumber = serial;
                Sensor = new TactileSensor(sensivity);
            }
        }
    }
}