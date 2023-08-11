using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Results;

namespace UseCases.Request
{
    public class PessoaBasicDataRequest : IRequest<PessoaBasicDataResult>
    {
        public Guid PessoaId { get; set; }
    }
}
