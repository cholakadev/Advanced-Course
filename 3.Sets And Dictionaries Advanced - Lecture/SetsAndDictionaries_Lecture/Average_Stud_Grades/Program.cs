using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Stud_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var studentInfo = new Dictionary<string, List<double>>(); 

            for (int i = 0; i < input; i++)
            {
                var studentGrade = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var student = studentGrade[0];
                var grade = double.Parse(studentGrade[1]);

                if (!studentInfo.ContainsKey(student))
                {
                    studentInfo.Add(student, new List<double>());
                    studentInfo[student].Add(grade);
                }
                else
                {
                    studentInfo[student].Add(grade);
                }
            }

            foreach (var student in studentInfo)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
