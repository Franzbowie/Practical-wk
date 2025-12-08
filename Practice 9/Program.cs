using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class Discipline
    {
        protected string Title;
    }

    interface IHaveAngryTeacher
    {

    }

    interface IHavePractice
    {
        public int PracticeCount { get; set; }

        bool Check(int count)
        {
            if (count >= PracticeCount)
                return true;

            return false;
        }
    }

    interface IHaveFinalControll
    {
        public int PassingScore { get; set; }

        bool Check(int score)
        {
            if (score >= PassingScore)
                return true;

            return false;
        }
    }

    class Student
    {
        public string Name { get; private set; }
        public Dictionary<IHavePractice, int> Practices { get; private set; }
        public Dictionary<IHaveFinalControll, int> FinalControls { get; private set; }

        public string Check(Discipline discipline)
        {

        }
    }

    class MathAnalysis : Discipline, IHaveFinalControll
    {
        public string Title { get; private set; } = "Матанализ";
        int IHaveFinalControll.PassingScore { get; set; } = 80;
    }

    class History : Discipline, IHaveFinalControll, IHavePractice
    {
        public string Title { get; private set; } = "История";
        int IHaveFinalControll.PassingScore { get; set; } = 70;
        int IHavePractice.PracticeCount { get; set; } = 16;
    }

    class Programming : Discipline, IHavePractice
    {
        public string Title { get; private set; } = "Программирование";
        int IHavePractice.PracticeCount { get; set; } = 10;
    }

    class English : Discipline
    {
        public string Title { get; private set; } = "Английский";
    }

    class PhysicalCulture : Discipline, IHaveAngryTeacher
    {
        public string Title { get; private set; } = "Физра";
    }
}