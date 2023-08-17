using System.ComponentModel.DataAnnotations;

namespace AdministracionUsuario.Entidades
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }

        public bool activo = true;

        public int IdUsuarioCreacion { get; set; }
    }
}
