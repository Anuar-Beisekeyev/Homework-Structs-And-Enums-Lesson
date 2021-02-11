using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkStructAndEnumsLesson
{
    public class Menu
    {
        Employee[] employees;
        public Menu(Employee[] employees)
        {
            this.employees = employees;
        }
        public void DataEntry()
        {
            int count = 1;
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();

                Console.WriteLine($"Введите полное имя сотрудника №{count}:");
                employees[i].Name = Console.ReadLine();

                Console.WriteLine($"Выберете должность сотрудника №{count}:");
                Console.WriteLine("1 - Босс\n2 - Менеджер\n3 - Продовец\n4 - Служащий");                
                if (!int.TryParse(Console.ReadLine(), out int possitionNumber))
                {
                    Console.WriteLine("Не верный ввод данных!");
                }
                switch (possitionNumber)
                {
                    case 1:
                        employees[i].Vacancy = Vacancies.Boss;
                        break;
                    case 2:
                        employees[i].Vacancy = Vacancies.Manager;
                        break;
                    case 3:
                        employees[i].Vacancy = Vacancies.Salesman;
                        break;
                    case 4:
                        employees[i].Vacancy = Vacancies.Clerk;
                        break;
                    default:
                        Console.WriteLine("Не верный ввод данных!");
                        return;
                        break;
                }
                Console.WriteLine($"Введите зарплату сотрудника №{count}: ");
               
                if (!int.TryParse(Console.ReadLine(), out int salary))
                {
                    Console.WriteLine("Не верный ввод данных!");
                    return;
                }
                else
                {
                    employees[i].Salary = salary;
                }
                Console.WriteLine($"Введите дату принятия на работу сотрудника №{count}: ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime date ))
                {
                    Console.WriteLine("Не верный ввод данных!");
                    return;
                }
                else
                {
                    employees[i].DateOfEmployment = date;
                }                
                count++;
                Console.WriteLine();
            }          

        }
        public void FullEmployeeInformation()
        {
            Console.WriteLine("Полная информация сотрудников:\n");
            Console.WriteLine("ФИО\t\tДолжность\t\tЗарплата\t\tДата приема на работу\n");
            for (int i = 0; i < employees.Length; i++)
            {                
                Console.Write(employees[i].Name + "\t\t");
                if (employees[i].Vacancy == Vacancies.Boss)
                {
                    Console.Write("Директор\t\t");
                }
                else if (employees[i].Vacancy == Vacancies.Clerk)
                {
                    Console.Write("Служащий\t\t");
                }
                else if (employees[i].Vacancy == Vacancies.Manager)
                {
                    Console.Write("Менеджер\t\t");
                }
                else if (employees[i].Vacancy == Vacancies.Salesman)
                {
                    Console.Write("Продавец\t\t");
                }
                Console.Write(employees[i].Salary + "\t\t");
                Console.Write(employees[i].DateOfEmployment + "\n");
            }
        }


    }
}
