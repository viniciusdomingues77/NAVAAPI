using Infrasctrucutre.Dabase;
using Infrasctrucutre.Interfaces;
using MediatR;
using System;
using UseCases.Exceptions;
using UseCases.Request;
using UseCases.Results;

public class PessoaBasicData : IRequestHandler<PessoaBasicDataRequest, PessoaBasicDataResult>
{
    IDataBaseInMemory dataBaseInMemory;
    public PessoaBasicData(IDataBaseInMemory dataBaseInMemory)
    {
        this.dataBaseInMemory = dataBaseInMemory;
    }

    public async Task<PessoaBasicDataResult> Handle(PessoaBasicDataRequest request, CancellationToken cancellationToken)
    {
        var Pessoas = await this.dataBaseInMemory.Get();
        var Pessoa = Pessoas.Where(p=> p.PessoaId == request.PessoaId).FirstOrDefault();
        if (Pessoa == null)
            throw new UseCaseException("Entity can not be found");

        return await Task.FromResult(new PessoaBasicDataResult { Name = Pessoa.Name, Surname = Pessoa.Surname });
    }
}

