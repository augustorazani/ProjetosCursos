using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas2
{
    internal class Program
    {
        static void Main(string[] args)
        {                
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary)); //envia os dados coletados como parâmetro para os atributos
                                                          //já instanciando o objeto com new
                Console.WriteLine();
            }
            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage); //chama o método da classe e envia o parâmetro coletado
            }
            else
            {
                Console.WriteLine("This id doesn't exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
