namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.AddSmartphone(new GentleSmartphone(1, 10));
            factory.AddSmartphone(new GentleSmartphone(2, 20));
            factory.AddSmartphone(new GentleSmartphone(3, 30));
            factory.AddSmartphone(new GentleSmartphone(4, 40));
            factory.AddSmartphone(new GentleSmartphone(5, 50));
            factory.AddSmartphone(new GentleSmartphone(6, 60));
            factory.AddSmartphone(new GentleSmartphone(7, 70));
            factory.AddSmartphone(new GentleSmartphone(8, 80));
            factory.AddSmartphone(new GentleSmartphone(9, 90));
            factory.AddSmartphone(new GentleSmartphone(10, 100));
            Customer customer1 = new Customer("Нагрыз", 15);
            Customer customer2 = new Customer("Марсель", 35);
            Customer customer3 = new Customer("Бактыбек", 80);
            Customer customer4 = new Customer("Смит", 30);
            Customer customer5 = new Customer("Дымов", 90);
            Customer customer6 = new Customer("Влад", 35);
            Customer customer7 = new Customer("Стэфан", 1);
            factory.Customers.Add((customer1));
            factory.Customers.Add((customer2));
            factory.Customers.Add((customer3));
            factory.Customers.Add((customer4));
            factory.Customers.Add((customer5));
            factory.Customers.Add((customer6));
            factory.Customers.Add((customer7));
            
            Console.WriteLine("Смартфоны на складе до продажи:");

            //Вывод списка телефонов до продажи
            foreach (var phone in factory.GetListSmartphones())
                Console.WriteLine($"Телефон #{phone.SerialNumber}, нежность {phone.GetSensivity(phone)}");

            Console.WriteLine("Покупатель:");

            //Вывод списка покупателей
            foreach (var customer in factory.Customers)
                Console.WriteLine($"{customer.FullName}, нежность {customer.GentleRate}");

            //Продажа телефонов
            factory.SaleSmartphone();

            Console.WriteLine("Смартфоны на складе после продажи:");

            //Вывод списка оставшихся телефонов
            foreach (var phone in factory.GetListSmartphones())
                Console.WriteLine($"Телефон #{phone.SerialNumber}, нежность {phone.GetSensivity(phone)}");

            if (factory.GetListSmartphones().Count == 0)
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