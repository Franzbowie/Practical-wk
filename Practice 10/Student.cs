namespace ConsoleApp1
{
    class Student : IComparable
    {
        public int Number;
        public int CountPhone;
        public int CountLunch;
        public Position Position;

        public Student(int number, int countPhone, int countLunch, Position position)
        {
            Number = number;
            CountPhone = countPhone;
            CountLunch = countLunch;
            Position = position;
        }

        /// <summary>
        /// Сравнение школьников по количетсву произведенных телефонов
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>результат сравнения - какой школьник быстрее</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int CompareTo(object obj)
        {
            if (obj is Student anotherStudent)
            {
                int phoneComparison = anotherStudent.CountPhone.CompareTo(CountPhone);

                if (phoneComparison != 0)
                    return phoneComparison;

                return Position.CompareTo(anotherStudent.Position);
            }

            throw new NotImplementedException();
        }
    }
}