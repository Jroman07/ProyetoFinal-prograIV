using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Final_PrograIV.Entities;
using Proyecto_Final_PrograIV.FinalProjectDataBase;

namespace Proyecto_Final_PrograIV.Services
{
    public class CompaniesService : ICompaniesService
    {
        private readonly FinalProjectDbContext _dbcontext;

        public CompaniesService(FinalProjectDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Company AddCompany(Company company)
        {
            _dbcontext.Companies.Add(company);
            _dbcontext.SaveChanges();
            return company;
        } // crear compania 

        public void DeleteCompany(int id)
        {
            Company? company = _dbcontext.Companies.Find(id);

            if (company != null)
            {
                _dbcontext.Companies.Remove(company);
                _dbcontext.SaveChanges();
            }
            else
            {
                throw new Exception("Company not found");
            }
        } // eliminar compania 

        public List<Company> GetAllCompanies()
        {
            return _dbcontext.Companies.ToList();
        }

        public Company GetCompanyById(int id)
        {
            Company? company = _dbcontext.Companies.Find(id);

            if (company != null)
            {
                return company;
            }
            else
            {
                throw new Exception("Company not found");
            }
        }

        public List<Company> GetCompanyByName(string name)
        {
            throw new NotImplementedException();
        }

        public Company UpdateCompany(int id, Company company)
        {
            Company? Updatecompany = _dbcontext.Companies.Find(id);

            if (Updatecompany != null)
            {
                Updatecompany.Name = company.Name;
                Updatecompany.Email = company.Email;
                Updatecompany.WebSite = company.WebSite;
                _dbcontext.SaveChanges();
                return Updatecompany;
            }
            else
            {
                throw new Exception("Company not found");
            }
        }

    }
}




/*
namespace Proyecto_Final_PrograIV.Services
{
    public class OfferService : IOfferService
    {

        private readonly FinalProjectDbContext _dbContext; // atributo de la base de datos para pderla usar 

        public OfferService(FinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        } // se crea un constructor 

        public Offer AddOffer(Offer offer)
        {
            _dbContext.Offers.Add(offer);
            _dbContext.SaveChanges();

            return offer;
        } // añadir oferta

        public void DeleteOffer(int Id)
        {
            Offer? DeleteOffer = _dbContext.Offers.Find(Id);

            if (DeleteOffer != null){
                _dbContext.Offers.Remove(DeleteOffer);

                _dbContext.SaveChanges();
            }else{
                throw new Exception("Candidate not found");
            }
        } // borrar todos

        public List<Offer> GetallOffers()
        {
            return _dbContext.Offers.ToList();
        } // mostrar todos

        public Offer GetOfferById(int Id)
        {
            Offer? offer = _dbContext.Offers.Find(Id);

            if (offer != null){
                return offer;
            }else{
                throw new Exception("Offer not found");
            }
        }

       

        public List<Offer> GetOffersByName(string? job)
        {
            {
                if (string.IsNullOrWhiteSpace(job))
                {
                    return _dbContext.Offers.ToList();
                }

                return _dbContext.Offers
                .Where(o => o.Job.ToLower().Contains(job.ToLower()))
                .ToList();
            }
        }


        public Offer UpdateOffer(int Id, Offer offer)
        {
            Offer? UpdateOffer = _dbContext.Offers.Find(Id);

            if (UpdateOffer != null)
            {

                UpdateOffer.Job = offer.Job;
                UpdateOffer.Description = offer.Description;
                _dbContext.SaveChanges();
                return UpdateOffer;
                
            }
            else
            {
                throw new Exception("Offer not found");
            }
        
        }// actualizar oferta
    }
}
*/