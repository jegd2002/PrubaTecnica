namespace pruebaTecnica.Models
{
    public class productos
    {
        public int Id { get; set; } 
        public string codigo { get; set; }    
        public string descripcion { get; set; } 
        public int[] listaDePrecios { get; set; }
        public string imagen { get; set; }
        public Boolean productoParaLaVenta { get; set; }
        public int porcentajeIva { get; set; }

    }
}
