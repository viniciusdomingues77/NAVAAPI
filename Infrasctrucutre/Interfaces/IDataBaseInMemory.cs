using core.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasctrucutre.Interfaces
{
    public interface IDataBaseInMemory
    {
        Task<List<Pessoa>> Get();
        void Insert();
    }
}
