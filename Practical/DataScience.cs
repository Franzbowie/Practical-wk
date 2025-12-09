namespace ConsoleApp1
{
    class DataScience : Department
    {
        public DataScience(string title, int numberOfPositions) : base(title, numberOfPositions) { }

        /// <summary>
        /// Помещает в коллекцию стажеров кандидатов с высокой успеваемостью и языком Python
        /// </summary>
        /// <param name="candidates">список кандидатов на стажировку</param>
        public override void TraineeDistribution(List<Student> candidates)
        {
            int count = 0;

            for (int i = candidates.Count - 1; i >= 0 && count < NumberOfPositions; i--)
            {
                Student student = candidates[i];

                if (student.Achievement >= 85 && student.ProgrammingLanguage == ProgrammingLanguage.Python)
                {
                    Trainees.Add(student);
                    candidates.RemoveAt(i);
                    count++;
                }
            }
        }
    }
}