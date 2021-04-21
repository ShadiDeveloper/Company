using System;
using System.Collections.Generic;
using System.Text;

namespace TestCompany.Repository.Models
{
   public class SAS : Company
    {
        public override double GetTax()
        {
            return 33;
        }
    }
}
