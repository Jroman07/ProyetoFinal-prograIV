using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Final_PrograIV.Entities;


namespace Proyecto_Final_PrograIV.Services
{
    public interface IOfferService
    {
        public List<Offer> GetallOffers();

        public Offer GetOfferById(int Id);

        public Offer AddOffer(Offer offer);

        public Offer UpdateOffer(int Id, Offer offer);

        public void DeleteOffer(int Id);

        public List<Offer> GetOffersByName(string? Name); 

        

    }
}