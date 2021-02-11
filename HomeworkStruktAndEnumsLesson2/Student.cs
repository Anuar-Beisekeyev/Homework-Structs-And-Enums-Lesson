using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HomeworkStruktAndEnumsLessonPartTwo
{
    public class Student 
    {
        public Student(string name, string group, double averageScore,
            double incomePerFamilyMember, Gender gender,FormOfTraining formOfTraining)
        {
            Name = name;
            Group = group;
            AverageScore = averageScore;
            IncomePerFamilyMember = incomePerFamilyMember;
            this.gender = gender;
            this.formOfTraining = formOfTraining;
        }
        public string Name { get; set; }
        public string Group { get; set; }
        public double AverageScore { get; set; }
        public double IncomePerFamilyMember { get; set; }
        private Gender gender;
        private FormOfTraining formOfTraining;

      
    }
}
