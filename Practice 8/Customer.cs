namespace ConsoleApp1
{
    partial class Program
    {
        class Customer
        {
            public GentleSmartphone Smartphone { get; set; }
            public string FullName { get; private set; }
            public byte GentleRate { get; private set; }
            public Transformator TransformModule { get; set; }

            public Customer(string fullName, byte gentleRate)
            {
                FullName = fullName;
                GentleRate = gentleRate;
            }
        }
    }
}