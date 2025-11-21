namespace ConsoleApp1
{
    class GameDevelopment : Department
    {
        public GameDevelopment(string title, int numberOfPositions) : base(title, numberOfPositions) { }

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
    }
}