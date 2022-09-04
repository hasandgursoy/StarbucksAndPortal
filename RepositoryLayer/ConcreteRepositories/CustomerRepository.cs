using CoreLayer.AbstractRepositories;
using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.ConcreteRepositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerManagerDbContext customerManagerDbContext) : base(customerManagerDbContext)
        {

        }
    }
}
