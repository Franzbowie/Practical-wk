namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; private set; }
        public Dictionary<IHavePractice, int> Practices { get; private set; }
        public Dictionary<IHaveFinalControll, int> FinalControls { get; private set; }

        public Student(string name)
        {
            Name = name;
            Practices = new Dictionary<IHavePractice, int>();
            FinalControls = new Dictionary<IHaveFinalControll, int>();
        }

        /// <summary>
        /// Проверка условий получения автомата по дисциплине
        /// </summary>
        /// <param name="discipline"></param>
        /// <returns>строка вывода в консоль</returns>
        public string Check(Discipline discipline)
        {
            if (discipline is IHaveAngryTeacher)
            {
                return $"У дисциплины {discipline.Title} злой препод. Автоматов не будет.";
            }

            if (discipline is IHaveFinalControll && discipline is IHavePractice)
            {
                History history = discipline as History;
                int practiceCount = Practices[history];
                bool practiceCompleted = ((IHavePractice)history).CheckPracticeCount(practiceCount);
                int finalControllCount = FinalControls[history];
                bool testCompleted = ((IHaveFinalControll)history).CheckFinalControll(finalControllCount);

                if (practiceCompleted && testCompleted)
                    return $"По дисциплине {discipline.Title} выполнены условия автомата.";

                else if (practiceCompleted && testCompleted == false)
                    return $"По дисциплине {discipline.Title} выполнены условия по количеству практик, однако не выполнено условие по финальному тесту. Без автомата(";


                else if (practiceCompleted == false && testCompleted)
                    return $"По дисциплине {discipline.Title} выполнено условие по финальному тесту, однако не выполнено условие по количеству практик. Без автомата(";

                else
                    return $"По дисциплине {discipline.Title} не выполнены условия автомата.";
            }

            if (discipline is IHavePractice)
            {
                Programming programming = discipline as Programming;
                int practiceCount = Practices[programming];
                bool practiceCompleted = ((IHavePractice)programming).CheckPracticeCount(practiceCount);

                if (practiceCompleted)
                {
                    return $"По дисциплине {discipline.Title} выполнены условия автомата. Практик сдано достаточно";
                }
                
                return $"По дисциплине {discipline.Title} не выполнены условия автомата.";
            }

            if (discipline is IHaveFinalControll)
            {
                MathAnalysis mathAnalysis = discipline as MathAnalysis;
                int finalControllCount = FinalControls[mathAnalysis];
                bool testCompleted = ((IHaveFinalControll)mathAnalysis).CheckFinalControll(finalControllCount);
                
                if (testCompleted)
                {
                    return $"По дисциплине {discipline.Title} выполнены условия автомата. Тест написан хорошо.";
                }

                return $"По дисциплине {discipline.Title} не выполнено условие по финальному тесту. Без автомата(";
            }

            if (discipline is IHaveFinalControll == false && discipline is IHavePractice == false)
            {
                return $"По дисциплине {discipline.Title} все получают автоматы.";
            }

            return "такой дисциплины нет";
        }

        /// <summary>
        /// Добавляет в словарь Practices количетсво сданных практик по дисциплине
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="count">объект дисциплина, количество сданным практик</param>
        public void SetPractice(Discipline discipline, int count)
        {
            if (discipline is IHavePractice practiceDiscipline)
            {
                Practices[practiceDiscipline] = count;
            }
        }

        /// <summary>
        /// Добавляет в словарь FinalControls балл финального теста по дисциплине
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="score">объект дисцилпина, балл по финальному тесту</param>
        public void SetFinalScore(Discipline discipline, int score)
        {
            if (discipline is IHaveFinalControll finalDiscipline)
            {
                FinalControls[finalDiscipline] = score;
            }
        }
    }
}