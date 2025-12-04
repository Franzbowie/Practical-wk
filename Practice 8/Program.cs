namespace ConsoleApp1
{
    partial class Program
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
    }
}