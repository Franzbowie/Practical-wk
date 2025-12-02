namespace ConsoleApp1
{
    class MobileApplicationDevelopment : Department
    {
        public MobileApplicationDevelopment(string title, int numberOfPositions) : base(title, numberOfPositions) { }

        //Помещает в коллекцию стажеров кандидатов c высокой успеваемостью, не ниже 3 курса, языком Dart
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
    }
}