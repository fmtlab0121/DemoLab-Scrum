using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleProject.Models.Contracts
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        string Hello();
    }
}
