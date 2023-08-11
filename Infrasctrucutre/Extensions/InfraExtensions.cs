using Infrasctrucutre.Dabase;
using Infrasctrucutre.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasctrucutre.Extensions
{
    public static class InfraExtensions
    {
        public static void AddInfraServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IDataBaseInMemory), typeof(DataBaseInMemory));
        }
    }
}
