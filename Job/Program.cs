using System;
using Job.Entities;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Criação de um array de funcionários
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>(n);

            /// Leitura dos dados dos funcionários

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            /// Exibe os dados dos funcionários
            Console.WriteLine("Payments: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(employees[i].Name + " - " + employees[i].Payment().ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
            }
        }
    }
}
