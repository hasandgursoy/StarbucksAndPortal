using CoreLayer.AbstractRepositories;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.ConcreteRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ServiceRegistration
    {
        public static void AddServiceLayerRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            
        }
    }
}
