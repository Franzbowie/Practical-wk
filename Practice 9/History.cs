namespace ConsoleApp1
{
    class History : Discipline, IHaveFinalControll, IHavePractice
    {
        int IHaveFinalControll.PassingScore { get; set; } = 70;
        int IHavePractice.PracticeCount { get; set; } = 16;

        public History()
        {
            Title = "История";
        }
    }
}