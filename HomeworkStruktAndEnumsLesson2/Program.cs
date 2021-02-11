using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkStruktAndEnumsLessonPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double minIncome = 42500;
            List<Student> students = new List<Student>();
            students.Add(new Student("Асанов А.Г", "ЭТХ-54", 8, 70000, Gender.Male, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Сапар К.Д", "СВ-157", 10, 160000, Gender.Male, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Жусупова с.Б", "БУ-26", 11, 98000, Gender.Female, FormOfTraining.DistanceLearning));
            students.Add(new Student("Петров С.И", "ЭТ-54", 12, 100000, Gender.Male, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Иванова М.Х", "ДС-112",11, 205000, Gender.Female, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Хасанов К.Н", "СВ-157", 9, 127000, Gender.Male, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Никитина С.Ю", "БУ-25", 10, 155000, Gender.Female, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Байболов М.А", "ПМ-117", 8, 170000, Gender.Male, FormOfTraining.DistanceLearning));
            students.Add(new Student("Салихов Б.К", "ДС-112", 9, 80000, Gender.Male, FormOfTraining.FullTimeTraining));
            students.Add(new Student("Нуртазина А.Р", "СВ-157", 10, 75000, Gender.Female, FormOfTraining.FullTimeTraining));
            Console.WriteLine("Полный спосок студентов:\n");
            Console.WriteLine("ФИО\t\t\tГрупа\t\tСредний балл\n");            
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}\t\t{student.Group}\t\t{student.AverageScore}");
            }

            List<Student> studentsFirstQueue = new List<Student>();
            List<Student> studentsSecondQueue = new List<Student>();            
            int i = 0;
            int count = 1;
            foreach (var student in students)
            {
                if (student.IncomePerFamilyMember < minIncome * 2)
                {
                    studentsFirstQueue.Add(students[i]);                    
                }
                else
                {
                    studentsSecondQueue.Add(students[i]);
                }
                i++;
            }
            var sortedIncomePerFamilyMember = studentsFirstQueue.OrderBy(st => st.IncomePerFamilyMember);
            var sortedAverageScore = studentsSecondQueue.OrderByDescending(st => st.AverageScore);
            students = sortedIncomePerFamilyMember.Concat(sortedAverageScore).ToList();
            Console.WriteLine();
            Console.WriteLine("Список учеников для предоставления общежития с учетом зароботка на члена семьи и среднего балла учащегося студента.\n");
            foreach (Student el in students)
            {
                Console.WriteLine($"{count} {el.Name}, {el.Group}");
                count++;
            }
            Console.ReadLine();

        }
    }
}
