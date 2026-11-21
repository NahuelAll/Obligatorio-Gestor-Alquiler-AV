namespace AV.Entities
{
    public class Administrador
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
