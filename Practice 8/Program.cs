namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.Smartphones.Add(new GentleSmartphone(1, 10));
            factory.Smartphones.Add(new GentleSmartphone(2, 20));
            factory.Smartphones.Add(new GentleSmartphone(3, 30));
            factory.Smartphones.Add(new GentleSmartphone(4, 40));
            factory.Smartphones.Add(new GentleSmartphone(5, 50));
            factory.Smartphones.Add(new GentleSmartphone(6, 60));
            factory.Smartphones.Add(new GentleSmartphone(7, 70));
            factory.Smartphones.Add(new GentleSmartphone(8, 80));
            factory.Smartphones.Add(new GentleSmartphone(9, 90));
            factory.Smartphones.Add(new GentleSmartphone(10, 100));
            factory.Customers.Add(new Customer("Нагрыз", 15));
            factory.Customers.Add(new Customer("Марсель", 35));
            factory.Customers.Add(new Customer("Бактыбек", 80));
            factory.Customers.Add(new Customer("Смит", 30));
            factory.Customers.Add(new Customer("Дымов", 90));
            factory.Customers.Add(new Customer("Влад", 35));
            factory.Customers.Add(new Customer("Стэфан", 1));
            Console.WriteLine("Смартфоны на складе до продажи:");

            //Вывод списка телефонов до продажи
            foreach (var phone in factory.Smartphones)
                Console.WriteLine($"Телефон #{phone.SerialNumber}, нежность {phone.Sensor.Sensivity}");

            Console.WriteLine("Покупатель:");

            //Вывод списка покупателей
            foreach (var customer in factory.Customers)
                Console.WriteLine($"{customer.FullName}, нежность {customer.GentleRate}");

            //Продажа телефонов
            factory.SaleSmartphone();

            Console.WriteLine("Смартфоны на складе после продажи:");

            //Вывод списка оставшихся телефонов
            foreach (var phone in factory.Smartphones)
                Console.WriteLine($"Телефон #{phone.SerialNumber}, нежность {phone.Sensor.Sensivity}");

            if (factory.Smartphones.Count == 0)
                Console.Write(" 0");

            Console.WriteLine("\nКлиенты:");

            //Вывод списка покупателей с их телефонами
            foreach (var customer in factory.Customers)
            {
                Console.Write($" {customer.FullName}, нежность {customer.GentleRate}");

                if (customer.Smartphone != null)
                {
                    Console.Write($", телефон #{customer.Smartphone.SerialNumber}");
                }

                else
                {
                    Console.Write(", нет телефона");
                }

                if (customer.TransformModule != null)
                {
                    Console.WriteLine($", трансформатор {customer.TransformModule.TransformType}.");
                }

                else
                {
                    Console.WriteLine(", нет трансформатора.");
                }
            }

        }

        class TactileSensor
        {
            public byte Sensivity { get; private set; }

            public TactileSensor(byte sensivity)
            {
                Sensivity = sensivity;
            }
        }

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

        class Transformator
        {
            public int SerialNumber { get; private set; }
            public TransformatorType TransformType { get; private set; }

            public Transformator(TransformatorType transformatorType)
            {
                TransformType = transformatorType;
            }
        }

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

        class Factory
        {
            public List<GentleSmartphone> Smartphones { get; private set; } = new List<GentleSmartphone>();
            public List<Customer> Customers { get; set; } = new List<Customer>();

            //Продажа телефонов
            public void SaleSmartphone()
            {
                for (int i = Customers.Count - 1; i >= 0; i--)
                {
                    for (int j = Smartphones.Count - 1; j >= 0; j--)
                    {
                        //Если не нужен трансформатор
                        if (Customers[i].GentleRate >= Smartphones[j].Sensor.Sensivity / 1.5
                            && Customers[i].GentleRate <= Smartphones[j].Sensor.Sensivity * 2)
                        {
                            Customers[i].Smartphone = Smartphones[j];
                            Smartphones.RemoveAt(j);
                            break;
                        }

                        //Если нужен умножитель
                        else if (Customers[i].GentleRate >= Smartphones[j].Sensor.Sensivity * 2 / 1.5 &&
                            Customers[i].GentleRate <= Smartphones[j].Sensor.Sensivity * 2 * 2)
                        {
                            Customers[i].TransformModule = new Transformator(TransformatorType.Multiplier);
                            Customers[i].Smartphone = Smartphones[j];
                            Smartphones.RemoveAt(j);
                            break;
                        }

                        //Если нужен делитель
                        else if (Customers[i].GentleRate >= Smartphones[j].Sensor.Sensivity / 2 / 1.5 &&
                            Customers[i].GentleRate <= Smartphones[j].Sensor.Sensivity / 2 * 2)
                        {
                            Customers[i].TransformModule = new Transformator(TransformatorType.Divider);
                            Customers[i].Smartphone = Smartphones[j];
                            Smartphones.RemoveAt(j);
                            break;
                        }
                    }
                }

                //Если все покупатели приобрели телефоны, оставшиеся нужно очистить со склада 
                bool allHavePhones = true;

                for (int i = Customers.Count - 1; i >= 0; i--)
                {
                    if (Customers[i].Smartphone == null)
                    {
                        allHavePhones = false;
                        break;
                    }
                }

                if (allHavePhones)
                    Smartphones.Clear();
            }
        }

        enum TransformatorType
        {
            Multiplier,
            Divider
        }
    }
}