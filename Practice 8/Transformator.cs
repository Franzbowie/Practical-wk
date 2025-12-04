namespace ConsoleApp1
{
    partial class Program
    {
        class Transformator
        {
            public int SerialNumber { get; private set; }
            public TransformatorType TransformType { get; private set; }

            public Transformator(TransformatorType transformatorType)
            {
                TransformType = transformatorType;
            }
        }
    }
}