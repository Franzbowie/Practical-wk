namespace ConsoleApp1
{
    partial class Program
    {
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
    }
}