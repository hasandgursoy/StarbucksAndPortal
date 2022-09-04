using CoreLayer.AbstractService;
using CoreLayer.Entities;
using CoreLayer.Repositories;
using RepositoryLayer.ConcreteRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ConcreteService
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        
    }
}
