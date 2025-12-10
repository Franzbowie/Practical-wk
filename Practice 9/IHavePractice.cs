namespace ConsoleApp1
{
    /// <summary>
    /// Автомат по количеству практик
    /// </summary>
    interface IHavePractice
    {
        public int PracticeCount { get; set; }

        bool CheckPracticeCount(int count)
        {
            if (count >= PracticeCount)
                return true;

            return false;
        }
    }
}