using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var average = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            
            foreach(var number in grades)
            {
                average += number;
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
            }
            average /= grades.Count;
            Console.WriteLine($"the lowest grade is {lowGrade}");
            Console.WriteLine($"the highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {average:N1}");
        }

        private List<double> grades;
    }
}