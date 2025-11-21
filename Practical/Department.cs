namespace ConsoleApp1
{
    class Department
    {
        public string Title { get; set; }
        public List<Student> Trainees { get; set; }
        public int NumberOfPositions { get; set; }

        public Department(string title, int numberOfPositions)
        {
            Title = title;
            NumberOfPositions = numberOfPositions;
            Trainees = new List<Student>();
        }

        public virtual void TraineeDistribution(List<Student> candidates)
        {
            for (int i = candidates.Count - 1; i >= 0; i--)
            {
                Student student = candidates[i];

                if (student.CourseNumber >= 2)
                {
                    Trainees.Add(student);
                    candidates.RemoveAt(i);
                }
            }

        }
    }
}