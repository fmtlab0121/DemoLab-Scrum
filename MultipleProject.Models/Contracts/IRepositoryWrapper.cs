using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleProject.Models.Contracts
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository Customers { get; }
        IDepartmentRepository Departments { get; }

        void Save();
    }
}
