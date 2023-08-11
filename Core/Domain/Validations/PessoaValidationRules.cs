using Core.Domain.Interfaces;
using System;

public class PessoaValidationRules: IPessoaValidationRules
{
	
	public PessoaValid IsValid(string Name, string Surname, Guid PessoaId, DateTime BirthDate)
	{
		PessoaValid pessoaValid = PessoaValid.Valid;

		if (String.IsNullOrEmpty(Name))
			pessoaValid = PessoaValid.Invalid;

        if (Name.Length < 3)
            pessoaValid = PessoaValid.Invalid;

        if (String.IsNullOrEmpty(Surname))
            pessoaValid = PessoaValid.Invalid;

        if (Surname.Length < 3)
            pessoaValid = PessoaValid.Invalid;

		DateTime DtAux ;
		if (!DateTime.TryParse(BirthDate.ToShortDateString(), out DtAux))
            pessoaValid = PessoaValid.Invalid;

        Guid GuidAux;
        if (!Guid.TryParse(PessoaId.ToString(), out GuidAux))
            pessoaValid = PessoaValid.Invalid;



        return pessoaValid;
	}

}
