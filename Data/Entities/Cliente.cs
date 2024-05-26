
namespace WebAPI.Data.Entities
{
    public class Cliente
    {
        public int clienteID { get; set;}
        public string? razonSocial { get; set;}
        public string? domicilio { get; set; }
        public string? telefono { get; set; }
        public string? rfc { get; set; }
    }
}