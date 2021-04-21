using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCompany.Enums;

namespace TestCompany.Models
{
    public class CompanyTaxModel
    {
        public double AnnualIncome { get; set; }
        public CompanyEnum Type { get; set; }
    }
}
