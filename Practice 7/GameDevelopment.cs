namespace ConsoleApp1
{
    class GameDevelopment : Department
    {
        public GameDevelopment(string title, int numberOfPositions) : base(title, numberOfPositions) { }

        //Помещает в коллекцию стажеров кандидатов не ниже 2 курса, высокой успеваемостью, языком C# или C++
        public override void TraineeDistribution(List<Student> candidates)
        {
            int count = 0;

            for (int i = candidates.Count - 1; i >= 0 && count < NumberOfPositions; i--)
            {
                Student student = candidates[i];

                if (student.CourseNumber >= 2 && student.Achievement >= 80 &&
                   (student.ProgrammingLanguage == ProgrammingLanguage.Cpp ||
                   student.ProgrammingLanguage == ProgrammingLanguage.Csharp))
                {
                    Trainees.Add(student);
                    candidates.RemoveAt(i);
                    count++;
                }
            }
        }

        //Выводит информацию о стажерах 
        public new string PrintTrainees(List<Student> trainees)
        {
            string studentsInfo = "";

            for (int i = 0; i < trainees.Count; i++)
            {
                studentsInfo += "Имя: ";
                studentsInfo += trainees[i].Name;
                studentsInfo += ", язык программирования: ";
                studentsInfo += trainees[i].ProgrammingLanguage;
                studentsInfo += "\n";
            }

            return studentsInfo;
        }
    }
}