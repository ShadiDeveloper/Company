using System;
using System.Collections.Generic;
using System.Text;

namespace TestCompany.Repository.Models
{
    public abstract class Company
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public string Name { get; set; }

        public abstract double GetTax();
    }
}
