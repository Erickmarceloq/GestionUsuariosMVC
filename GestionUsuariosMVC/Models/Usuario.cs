using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionUsuariosMVC.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo { get; set; }

        [Required]
        public int IdRol { get; set; }

        // Propiedad de navegación hacia el Rol
        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; }
    }
}