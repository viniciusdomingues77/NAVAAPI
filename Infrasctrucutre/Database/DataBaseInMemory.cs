using core.entities;
using Core.Domain.Interfaces;
using Infrasctrucutre.Interfaces;
using System.Dynamic;

namespace Infrasctrucutre.Dabase
{
    public class DataBaseInMemory: IDataBaseInMemory
    {
        private List<Pessoa> PessoasDB = new List<Pessoa>();

        IPessoaValidationRules pessoaValidationRules;
        public DataBaseInMemory(IPessoaValidationRules pessoaValidationRules) 
        { 
            this.pessoaValidationRules = pessoaValidationRules;
        }
        public async Task<List<Pessoa>> Get()
        {
            return await Task.FromResult(PessoasDB);
        }
        public void Insert()
        {
            PessoasDB.AddRange(new[] {
                new Pessoa(this.pessoaValidationRules).Create("Vinicius", "Domingues", new Guid("a1e2f59b-d521-4be0-aef6-b9ada3fb026a"), new DateTime(1977, 1, 14)),
                new Pessoa(this.pessoaValidationRules).Create("Leonardo", "Simas", new Guid("c0e7bd48-3128-4944-a8e5-ba9d3cee514d"), new DateTime(1977, 1, 02)),
                new Pessoa(this.pessoaValidationRules).Create("Erasmo", "Rodrigues", new Guid("757b8ea0-8f8a-4c80-91b7-60e9ff5c4260"), new DateTime(1949, 12, 03))
            });
        }

    }
}