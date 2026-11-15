namespace AV.Entities
{
    public class EstadoEquipo
    {
        public int Id { get; set; }
        public required string TipoEstado { get; set; }
        public required string Descripcion { get; set; }
    }
}