using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Proyecto_Final_PrograIV.Entities
{
    public class OfertaHabilidad
    {
        
        public int OfertaId { get; set; }
        public Oferta Oferta {get; set;}
        
        public int HabilidadId {get; set;}
        public Habilidad habilidad {get;set;}

    }
}
