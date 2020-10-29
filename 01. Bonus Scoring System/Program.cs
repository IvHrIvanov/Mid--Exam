using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            int studentAttendances = 0;
            for (int i = 0; i < student; i++)
            {
                int attendaces = int.Parse(Console.ReadLine());
                double totalBonus = ((attendaces * 1.0) / (lectures * 1.0)) * (5 + (bonus * 1.0));
                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendances = attendaces;
                }

            }
            if(maxBonus<0)
            {
                maxBonus = 0;
            }    
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}