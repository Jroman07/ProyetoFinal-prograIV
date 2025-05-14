namespace Proyecto_Final_PrograIV.Entities
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string SitioWeb { get; set; }
        public string Email { get; set; }

        // Relación inversa: Una empresa tiene muchas ofertas
        public List<Oferta>? Ofertas { get; set; }
    }
}
