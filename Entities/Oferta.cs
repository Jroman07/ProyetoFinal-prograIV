namespace Proyecto_Final_PrograIV.Entities
{
    public class Oferta
    {
        public int OfertaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Clave Foránea
        public int EmpresaId { get; set; }
        // Propiedad de navegación (relación con Empresa)
        public Empresa? Empresa { get; set; }
        public IList<Habilidad> OfertaHabilidades { get; set; }
    }
}
