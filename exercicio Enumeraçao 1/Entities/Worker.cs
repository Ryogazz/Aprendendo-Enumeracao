using exercicio_Enumeraçao_1.Entities.Enums;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace exercicio_Enumeraçao_1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //Associaçao com a classe departamente permitindo ligar a classe work nela
        public Departament Departament { get; set; }
        //Associaçao em formato list pois podem ser mais de contato para cada worker
        // ja intaciamos contracts com nwe list para ele nao retonar nulo
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); 

        public Worker()
        {
               
        }
        //Construtor para guardar os valores declarados 
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        //metodo para adicionar contrato 
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        //metodo para remover contrato 

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //Metodo para definir quanto o funcionario recebeu no mes.
         public double income (int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
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
