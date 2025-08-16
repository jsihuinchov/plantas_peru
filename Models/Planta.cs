namespace plantas_peru.Models  
{
    public class Planta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public string Especie { get; set; }
        public decimal AlturaMaxima { get; set; }
        public string Notas { get; set; }
        public string ImagenUrl { get; set; }
    }
}
