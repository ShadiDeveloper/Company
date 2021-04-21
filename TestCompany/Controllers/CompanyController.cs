using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCompany.Models;
using TestCompany.Enums;
using TestCompany.Repository.Models;

namespace TestCompany.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public CompanyController()
        {

        }

        [HttpPost("tax")]
        public double CalculateTax(CompanyTaxModel vm)
        {
            //we can use switch-case when companies is alot
            //for big project business login should be in service file
            Company company;
            if (vm.Type == CompanyEnum.SelfEnterprise)
            {
                company = new Sel_Enterprise();
            }
            else
            {
                company = new SAS();
            }
            double percentTax = company.GetTax();
            double tax = vm.AnnualIncome * (percentTax * 100);

            return tax;
        }
    }
}
