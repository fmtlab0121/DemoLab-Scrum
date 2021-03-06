using MultipleProject.Models;
using MultipleProject.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLab_Scrum.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private ICustomerRepository _owner;
        private IDepartmentRepository _department;


        public ICustomerRepository Customers
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new CustomerRepository(_repoContext);
                }
                return _owner;
            }
        }

        public IDepartmentRepository Departments
        {
            get
            {
                if (_department == null)
                {
                    _department = new DepartmentRepository(_repoContext);
                }
                return _department;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }

    }
}
