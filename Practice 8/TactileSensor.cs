namespace ConsoleApp1
{
    partial class Program
    {
        class TactileSensor
        {
            public byte Sensivity { get; private set; }

            public TactileSensor(byte sensivity)
            {
                Sensivity = sensivity;
            }
        }
    }
}