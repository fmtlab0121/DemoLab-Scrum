using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MultipleProject.Models
{
    public class Customer
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Customer()
        {

        }

        public Customer(int pId, string pName)
        {
            Id = pId;
            Name = pName;
        }
    }
}
