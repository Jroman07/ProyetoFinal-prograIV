using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Final_PrograIV.Entities;

namespace Proyecto_Final_PrograIV.Services
{
    public interface ICompaniesService
    {
        public List<Company> GetAllCompanies();


        public Company AddCompany(Company company);

        public Company UpdateCompany(int id, Company company);

        public void DeleteCompany(int id);

        public Company GetCompanyById(int id);

         public List<Company> GetCompanyByName(string name);
    }
}