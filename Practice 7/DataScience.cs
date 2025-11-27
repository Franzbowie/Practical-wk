namespace ConsoleApp1
{
    class DataScience : Department
    {
        public DataScience(string title, int numberOfPositions) : base(title, numberOfPositions) { }

        //Помещает в коллекцию стажеров кандидатов с высокой успеваемостью и языком Python
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

        //Выводит информацию о стажерах 
        public new string PrintTrainees(List<Student> trainees)
        {
            string studentsInfo = "";

            for (int i = 0; i < trainees.Count; i++)
            {
                studentsInfo += "Имя: ";
                studentsInfo += trainees[i].Name;
                studentsInfo += ", успеваемость: ";
                studentsInfo += trainees[i].Achievement;
                studentsInfo += "\n";
            }

            return studentsInfo;
        }
    }
}