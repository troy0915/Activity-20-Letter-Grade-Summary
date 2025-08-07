using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_20Letter_Grade_Summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numericalGrades = new List<int>();
            Dictionary<char, int> gradeCounts = new Dictionary<char, int>()
        {
            {'A', 0},
            {'B', 0},
            {'C', 0},
            {'D', 0},
            {'F', 0}
        };
            Console.WriteLine("Enter 10 numerical grades (0-100):");
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    Console.Write($"Grade {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
                    {
                        numericalGrades.Add(grade);
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a number between 0-100.");
                }
            }
            Console.WriteLine("\nGrade Conversion Results:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Numerical\tLetter");
            Console.WriteLine("---------\t------");

            foreach (int grade in numericalGrades)
            {
                char letterGrade = ConvertToLetterGrade(grade);
                gradeCounts[letterGrade]++;
                Console.WriteLine($"{grade}\t\t{letterGrade}");
            }
            Console.WriteLine("\nGrade Distribution:");
            Console.WriteLine("-------------------");
            foreach (var kvp in gradeCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} student(s)");
            }
        }

        static char ConvertToLetterGrade(int score)
        {
            switch (score)
            {
                case int n when n >= 90 && n <= 100:
                    return 'A';
                case int n when n >= 80 && n < 90:
                    return 'B';
                case int n when n >= 70 && n < 80:
                    return 'C';
                case int n when n >= 60 && n < 70:
                    return 'D';
                default:
                    return 'F';
            }
        }
    }
}





