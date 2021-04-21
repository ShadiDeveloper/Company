using System;
using System.Collections.Generic;
using System.Text;

namespace TestCompany.Repository.Models
{
    public class Sel_Enterprise:Company
    {
        public string Address { get; set; }

        public override double GetTax()
        {
            return 25;
        }
    }
}
