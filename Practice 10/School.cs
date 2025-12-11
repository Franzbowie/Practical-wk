namespace ConsoleApp1
{
    class School
    {
        public List<Student> Students {  get; private set; }

        public School(List<Student> students)
        {
            Students = students;
        }

        /// <summary>
        /// Нахождение лучшего и худшего школьников
        /// </summary>
        /// <returns>Кортеж с лучшим и худшим школьниками</returns>
        public Tuple<Student, Student> FindMaxAndMinEmployee()
        {
            Students.Sort();
            Student maxEmployee = Students[0];
            Student minEmployee = Students[Students.Count - 1];
            return Tuple.Create(maxEmployee, minEmployee);
        }

        /// <summary>
        /// Прибавление еды лучшему и отнятие у худшего
        /// </summary>
        /// <param name="students"></param>
        public void Reward(Tuple<Student, Student> students)
        {
            Student maxEmployee = students.Item1;
            Student minEmployee = students.Item2;
            Student speedRunner = new Student(maxEmployee.Number, maxEmployee.CountPhone, maxEmployee.CountLunch + 1, maxEmployee.Position);
            Student outsider = new Student(minEmployee.Number, minEmployee.CountPhone, minEmployee.CountLunch -1, minEmployee.Position);

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Number == speedRunner.Number)
                    Students[i] = speedRunner;
                
                else if (Students[i].Number == outsider.Number)
                    Students[i] = outsider;
            }
        }
    }
}