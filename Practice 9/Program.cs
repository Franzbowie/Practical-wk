namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            History history = new History();
            Programming programming = new Programming();
            MathAnalysis mathAnalysis = new MathAnalysis();
            PhysicalCulture physicalCulture = new PhysicalCulture();
            English english = new English();
            Discipline[] disciplines = new Discipline[]
            {
                history,
                programming,
                mathAnalysis,
                physicalCulture,
                english
            };
            Student[] students = new Student[]
            {
                new Student("Артём"),
                new Student("Игорь"),
                new Student("Денис"),
                new Student("Алексей")
            };

            students[0].SetPractice(history, 16); 
            students[0].SetFinalScore(history, 69); 
            students[0].SetPractice(programming, 9); 
            students[0].SetFinalScore(mathAnalysis, 85);
            students[0].SetPractice(english, 10);
            students[0].SetPractice(physicalCulture, 11);

            students[1].SetPractice(history, 3);
            students[1].SetFinalScore(history, 0);
            students[1].SetPractice(programming, 6);
            students[1].SetFinalScore(mathAnalysis, 97);
            students[1].SetPractice(english, 10);
            students[1].SetPractice(physicalCulture, 11);

            students[2].SetPractice(history, 15);
            students[2].SetFinalScore(history, 54);
            students[2].SetPractice(programming, 15);
            students[2].SetFinalScore(mathAnalysis, 90);
            students[2].SetPractice(english, 10);
            students[2].SetPractice(physicalCulture, 11);

            students[3].SetPractice(history, 0);
            students[3].SetFinalScore(history, 0);
            students[3].SetPractice(programming, 12);
            students[3].SetFinalScore(mathAnalysis, 30);
            students[3].SetPractice(english, 10);
            students[3].SetPractice(physicalCulture, 11);

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);

                foreach (var discipline in disciplines)
                {
                    Console.WriteLine(student.Check(discipline));
                }

                Console.WriteLine();
            }
        }
    }
}