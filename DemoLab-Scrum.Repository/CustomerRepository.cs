using MultipleProject.Models;
using MultipleProject.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLab_Scrum.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public string Hello()
        {
            return "Hello world !";
        }
    }
}
