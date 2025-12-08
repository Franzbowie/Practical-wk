namespace ConsoleApp1
{
    class MobileApplicationDevelopment : Department
    {
        public MobileApplicationDevelopment(string title, int numberOfPositions) : base(title, numberOfPositions) { }

        /// <summary>
        /// //Помещает в коллекцию стажеров кандидатов c высокой успеваемостью, не ниже 3 курса, языком Dart
        /// </summary>
        /// <param name="candidates"></param>
        public override void TraineeDistribution(List<Student> candidates)
        {
            int count = 0;

            for (int i = candidates.Count - 1; i >= 0 && count < NumberOfPositions; i--)
            {
                Student student = candidates[i];

                if (student.Achievement >= 90 &&
                    student.ProgrammingLanguage == ProgrammingLanguage.Dart &&
                    student.CourseNumber >= 3)
                {
                    Trainees.Add(student);
                    candidates.RemoveAt(i);
                    count++;
                }
            }
        }

        /// <summary>
        /// Выводит информацию о стажерах
        /// </summary>
        /// <param name="trainees"></param>
        /// <returns></returns>
        public new string PrintTrainees(List<Student> trainees)
        {
            string studentsInfo = "";

            for (int i = 0; i < trainees.Count; i++)
            {
                studentsInfo += "Имя: ";
                studentsInfo += trainees[i].Name;
                studentsInfo += ", курс: ";
                studentsInfo += trainees[i].CourseNumber;
                studentsInfo += ", язык программирования: ";
                studentsInfo += trainees[i].ProgrammingLanguage;
                studentsInfo += "\n";
            }

            return studentsInfo;
        }
    }
}