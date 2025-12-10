namespace ConsoleApp1
{
    class Programming : Discipline, IHavePractice
    {
        int IHavePractice.PracticeCount { get; set; } = 10;

        public Programming()
        {
            Title = "Программирование";
        }
    }
}