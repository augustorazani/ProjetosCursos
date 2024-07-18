using System;
using System.Globalization;
using WorkerProje.Entities;
using WorkerProje.Entities.Enums;

namespace WorkerProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level Junior/MidLevel/Senior: ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine(), true);
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName); //instanciando os dois objetos já os relacionando
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter # {i} contract data:");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours); //instancia o contrato cada loop
                worker.AddContract(contract); //adiciona o contrato ao trabalhador cada loop do for
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2)); //recorta o resultado recebido da posicao 0 ate 2 da string
            int year = int.Parse(monthAndYear.Substring(3)); //recorta da posicao 3 ate o final
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name); //navega com . na memoria
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
            Console.ReadLine();
        }
    }
}
