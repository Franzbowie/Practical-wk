namespace ConsoleApp1
{
    /// <summary>
    /// Автомат по финальному тесту 
    /// </summary>
    interface IHaveFinalControll
    {
        public int PassingScore { get; set; }

        bool CheckFinalControll(int score)
        {
            if (score >= PassingScore)
                return true;

            return false;
        }
    }
}