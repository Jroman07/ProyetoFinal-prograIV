using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_PrograIV.Entities;
using Proyecto_Final_PrograIV.Services;

namespace Proyecto_Final_PrograIV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesService _companyService;

        public CompaniesController(ICompaniesService companyService)
        {
            _companyService = companyService;
        }

        // GET: api/Companies
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _companyService.GetAllCompanies();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            return _companyService.GetCompanyById(id);
        }

        // GET: api/Companies/search?name=value
        [HttpGet("search")]
        public IEnumerable<Company> Get([FromQuery] string? name)
        {
            return _companyService.GetCompanyByName(name);
        }

        // POST: api/Companies
        [HttpPost]
        public Company Post([FromBody] Company company)
        {
            return _companyService.AddCompany(company);
        }

        // PUT: api/Companies/5
        [HttpPut("{id}")]
        public Company Put(int id, [FromBody] Company company)
        {
            return _companyService.UpdateCompany(id, company);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _companyService.DeleteCompany(id);
            return NoContent(); // 204
        }   

    }
}
