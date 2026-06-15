using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuariosMVC.Models
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreRol { get; set; }

        // Relación inversa para Entity Framework
        public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}