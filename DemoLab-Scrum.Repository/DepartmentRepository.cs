using MultipleProject.Models;
using MultipleProject.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLab_Scrum.Repository
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(RepositoryContext repositoryContext)
                : base(repositoryContext)
        {
        }


    }
}
