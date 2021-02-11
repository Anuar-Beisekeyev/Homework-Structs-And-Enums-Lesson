using System;

namespace HomeworkStructAndEnumsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Введите количество сотрудников: ");                
            
            if (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Не верный ввод данных!");
            }
            Employee[] employees = new Employee[size];

            var menu = new Menu(employees);
            menu.DataEntry();
            menu.FullEmployeeInformation();
            Array.Sort(employees);

            Console.WriteLine();
            Console.WriteLine("Список менеджеров чьи зарпалты выше средней зарплаты всех служащих");
            int SummaSalaryCleark = 0;
            int count = 1;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Vacancy == Vacancies.Clerk)
                {
                    SummaSalaryCleark += employees[i].Salary;
                    count++;
                }
            }
            int averageSalary = SummaSalaryCleark / count;            
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Vacancy == Vacancies.Manager)
                {
                    if (employees[i].Salary > averageSalary)
                    {
                        
                        Console.WriteLine(employees[i].Name);
                    }
                }
            }
            Console.WriteLine("Список сотрудников принятых на долженность позже директора ");
            var date = new DateTime();
            for (int i = 0; i < employees.Length; i++)
            {
                
                if (employees[i].Vacancy == Vacancies.Boss )
                {
                    date = employees[i].DateOfEmployment;
                }
            }
            for (int i = 0; i < employees.Length; i++)
            {

                if (date < employees[i].DateOfEmployment )
                {
                    Console.WriteLine(employees[i].Name);
                }
            }
            Console.WriteLine(); 
            
        }
    }
}
