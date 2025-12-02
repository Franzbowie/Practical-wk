namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> candidates = new List<Student>
            {
                new Student { Name = "Ногтей Нагрыз Ибрагимович", CourseNumber = 3, ProgrammingLanguage = ProgrammingLanguage.Csharp, Achievement = 85 },
                new Student { Name = "Мария", CourseNumber = 2, ProgrammingLanguage = ProgrammingLanguage.Cpp, Achievement = 80 },
                new Student { Name = "Петр", CourseNumber = 4, ProgrammingLanguage = ProgrammingLanguage.Python, Achievement = 88 },
                new Student { Name = "Иван", CourseNumber = 1, ProgrammingLanguage = ProgrammingLanguage.Dart, Achievement = 92 },
                new Student { Name = "Елена", CourseNumber = 3, ProgrammingLanguage = ProgrammingLanguage.Dart, Achievement = 95 },
                new Student { Name = "Сергей", CourseNumber = 2, ProgrammingLanguage = ProgrammingLanguage.Java, Achievement = 82 },
                new Student { Name = "Ольга", CourseNumber = 2, ProgrammingLanguage = ProgrammingLanguage.Python, Achievement = 84 },
                new Student { Name = "Владимир", CourseNumber = 4, ProgrammingLanguage = ProgrammingLanguage.Javascript, Achievement = 91 },
                new Student { Name = "Анна", CourseNumber = 3, ProgrammingLanguage = ProgrammingLanguage.Csharp, Achievement = 88 },
                new Student { Name = "Дмитрий", CourseNumber = 2, ProgrammingLanguage = ProgrammingLanguage.Cpp, Achievement = 78 }
            };

            GameDevelopment gameDevelopment = new GameDevelopment("GameDevelopment", 2);
            DataScience dataSciense = new DataScience("DataSciense", 2);
            MobileApplicationDevelopment mobileApplicationDevelopment = new MobileApplicationDevelopment("MobileApplicationDevelopment", 2);
            List<Department> departments = new List<Department>();
            departments.Add(gameDevelopment);
            departments.Add(dataSciense);
            departments.Add(mobileApplicationDevelopment);

            //Распределение кандидатов по отделам
            foreach (Department department in departments)
                department.TraineeDistribution(candidates);

            //Выводит информацию о стажерах 
            foreach (Department department in departments)
            {
                Console.WriteLine($"Подразделение: {department.Title}");

                if (department.Trainees.Count == 0)
                {
                    Console.WriteLine("Нет стажёров.");
                }

                else
                {
                    foreach (Student trainee in department.Trainees)
                    {
                        Console.WriteLine($"Имя студента: {trainee.Name}, курс: {trainee.CourseNumber}, успеваемость: {trainee.Achievement}, язык программирования: " +
                            $"{trainee.ProgrammingLanguage}");
                    }
                }
            }

            Console.WriteLine($"Не прошли на стажировку:");

            foreach (Student student in candidates)
                Console.WriteLine($"Имя студента: {student.Name}, курс: {student.CourseNumber}, успеваемость: {student.Achievement}, язык программирования: " +
                    $"{student.ProgrammingLanguage}");
        }
    }
}