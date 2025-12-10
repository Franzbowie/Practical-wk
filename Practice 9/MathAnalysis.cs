namespace ConsoleApp1
{
    class MathAnalysis : Discipline, IHaveFinalControll
    {
        int IHaveFinalControll.PassingScore { get; set; } = 80;

        public MathAnalysis()
        {
            Title = "Матанализ";
        }
    }
}