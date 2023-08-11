using Core.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class CoreExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPessoaValidationRules), typeof(PessoaValidationRules));
        }
    }
}
