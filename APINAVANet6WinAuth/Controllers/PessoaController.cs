using Infrasctrucutre.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UseCases.Request;
using UseCases.Results;

namespace APINAVANet6WinAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        IMediator _mediator;
        IDataBaseInMemory dataBaseInMemory;

        public PessoaController(IMediator _mediator,IDataBaseInMemory dataBaseInMemory) 
        { 
            this._mediator = _mediator;
            this.dataBaseInMemory = dataBaseInMemory;
            this.dataBaseInMemory.Insert();    
        }

        
        [HttpGet(Name="nome")]
        public async Task<PessoaBasicDataResult> Get([FromQuery] PessoaBasicDataRequest request)
        {
            var result = await this._mediator.Send(request);
            return result;
        }
    }
}
