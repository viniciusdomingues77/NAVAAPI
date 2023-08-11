using Core.Domain.Interfaces;
using System;
using System.Runtime.CompilerServices;

namespace core.entities; 
public class Pessoa
{
    public string Name { get; private set; }
    public  string Surname { get; private set; }
    public Guid PessoaId { get; private set; }
    public DateTime BirthDate { get; private set; }

    private IPessoaValidationRules pessoaValidationRules;

    public Pessoa(IPessoaValidationRules pessoaValidationRules)
    {
        this.pessoaValidationRules = pessoaValidationRules;
    }
    
    private Pessoa(string Name, string Surname, Guid PessoaId, DateTime BirthDate)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.PessoaId = PessoaId;
        this.BirthDate = BirthDate;
    }
    
    public  Pessoa Create(string Name, string Surname, Guid PessoaId, DateTime BirthDate)
    {
       
        if (this.pessoaValidationRules.IsValid(Name,Surname,PessoaId,BirthDate) == PessoaValid.Invalid)
            throw new PessoaException("Invalid Object");
        

        return new Pessoa(Name,Surname, PessoaId, BirthDate);
    }
}
