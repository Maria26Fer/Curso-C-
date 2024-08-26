using Course.Entities.Enums;
using System.Collections.Generic;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        /*
         * Assim que se referencia uma classe com outra;
         1- Realiza a importação do arquivo;
         2- Depois define o tipo do atributo como a classe que se está referenciando;
         */

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        /*Um trabalhador pode ter varios contratos
        Então usas se uma List para representar todos os contratos que um trabalhador pode ter;*/
        public Worker () 
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Esse é um metodo/função que irei chamar quando adicionar um contrato ao trabalhador
        public void AddContract(HourContract contract) 
        {
            //a funcionalidade irá acessar minha list de contracts e realizara a funcionalidade estabelecida
            Contracts.Add(contract);
        }

        //Esse é um metodo/função que irei chamar quando quiser excluir um contrato do trabalhador
        public void RemoveContract(HourContract contract) 
        { 
            Contracts.Remove(contract); 
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;
            /*
             Para cada HourContract da minha list de Contracts eu vou verificar se
            o ano do meu contrato for igual ao ano que recebi como argumento e também
            o mes do contrato for igual ao mes que estou recebendo o contrato significa que o
            contrato vai entrar na soma
             */
            foreach (HourContract contract in Contracts) { 
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();//operação que retorna o valor do contrato
                }
            }
            return sum;
        }
    }
}
