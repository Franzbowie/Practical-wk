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

        /// <summary>
        /// //Помещает в коллекцию стажеров кандидатов не ниже 2 курса
        /// </summary>
        /// <param name="candidates"></param>
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

        /// <summary>
        /// Выводит информацию о стажерах
        /// </summary>
        /// <param name="trainees"></param>
        /// <returns>строка вывода</returns>
        public string PrintTrainees(List<Student> trainees)
        {
            string studentsInfo = "";

            for (int i = 0; i < trainees.Count; i++)
            {
                studentsInfo += trainees[i].Name;
                studentsInfo += "\n";
            }

            return studentsInfo;
        }
    }
}