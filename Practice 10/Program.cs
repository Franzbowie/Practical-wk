namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Время со структурой: 0,6112887; 0,6318379; 0,6586262
            //Время с классом: 0,4903547;  0,5088459; 0,4803789
            DateTime start = DateTime.Now;
            List<Student> students = new List<Student>();

            for (int i = 0; i < 1000000; i++ )
            {
                students.Add(new Student(i, i, i, Position.Senior));
            }

            School school = new School(students);
            school.Reward(school.FindMaxAndMinEmployee());
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalSeconds);
        }
    }
}