using AV.Entities.Enumerators;

namespace AV.Entities
{
    public class EstadoEquipo
    {
        public int Id { get; set; }
        public TipoEstado TipoEstado { get; set; }
        public string? Descripcion { get; set; }
    }
}