using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HomeworkStructAndEnumsLesson
{
    public class Employee : IComparable<Employee>
    {
        public string Name { get; set; }

        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public DateTime  DateOfEmployment { get; set; }

        public int CompareTo( Employee other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
