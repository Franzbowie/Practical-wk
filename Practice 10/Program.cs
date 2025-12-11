namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Время со структурой: 0,0120013; 0,0123281; 0,0109638
            //Время с классом: 0,0102904, 0,0091065, 0,0095644
            DateTime start = DateTime.Now;
            List<Student> students = new List<Student>
            {
                new Student(1, 1, 1, Position.Junior),
                new Student(2, 2, 2, Position.Junior),
                new Student(3, 3, 3, Position.Junior),
                new Student(4, 4, 4, Position.Junior),
                new Student(5, 5, 5, Position.Middle),
                new Student(6, 6, 6, Position.Middle),
                new Student(7, 7, 7, Position.Middle),
                new Student(8, 8, 8, Position.Senior),
                new Student(9, 9, 9, Position.Senior),
                new Student(10, 10, 10, Position.Senior),
            };
            School school = new School(students);
            school.Reward(school.FindMaxAndMinEmployee());
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalSeconds);
        }
    }
}