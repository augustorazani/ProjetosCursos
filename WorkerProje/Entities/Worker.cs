using System;
using System.Collections.Generic;
using WorkerProje.Entities.Enums;

namespace WorkerProje.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //realiza o relacionamento da classe Worker com seu respectivo departamento
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //relaciona o trabalhador com uma lista de N contratos e ja instancia para garantir que não seja null

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) //jamais incluir no ctor classes com asossiações para N contratos (muitos)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); //adiciona o contrato na lita de contratos
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); //remove o contrato
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary; //salario base do trabalhador (sempre irá ganhar)

            foreach (HourContract contract in Contracts) 
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
