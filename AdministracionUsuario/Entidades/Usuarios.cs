using System.ComponentModel.DataAnnotations;

namespace AdministracionUsuario.Entidades
{
    public class Usuarios
    {
        [Key]
        public string? usuario {get; set; }
        public string? email { get; set; }
        public string? primerNombre { get; set; }
        public string? segundoNombre { get; set; }
        public string? primerApellido{ get; set; }
        public string? segundoApellido { get; set; }
        public int? IdDepartamento { get; set; }
        public int? IdCArgo { get; set; }

    }
}
