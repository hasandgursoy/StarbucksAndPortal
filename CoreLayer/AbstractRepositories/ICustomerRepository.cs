using CoreLayer.Entities;
using CoreLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.AbstractRepositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
}
