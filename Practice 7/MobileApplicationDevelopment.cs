namespace ConsoleApp1
{
    class MobileApplicationDevelopment : Department
    {
        public MobileApplicationDevelopment(string title, int numberOfPositions) : base(title, numberOfPositions) { }

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

        public new string PrintTrainees(List<Student> trainees)
        {
            string studentsInfo = "";

            for (int i = 0; i < trainees.Count; i++)
            {
                studentsInfo += trainees[i].Name;
                studentsInfo += " ";
                studentsInfo += trainees[i].CourseNumber;
                studentsInfo += " ";
                studentsInfo += trainees[i].ProgrammingLanguage;
                studentsInfo += "\n";
            }

            return studentsInfo;
        }
    }
}