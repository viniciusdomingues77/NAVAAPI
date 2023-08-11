using Core.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UseCases.Request;
using UseCases.Results;

namespace UseCases.Extension
{
    public static class UseCaseExtensions
    {
        public static void AddUseCaseExtensions(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddScoped(typeof(IPessoaValidationRules), typeof(PessoaValidationRules));
        }
    }
}
