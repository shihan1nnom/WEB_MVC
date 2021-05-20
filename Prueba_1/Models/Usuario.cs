using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba_1.Models
{
    public class Usuario
    {
        [Key, Column(Order = 1)]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres maximo 50")]
        public string TipoIdent { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string NumIdent { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string FullName()
        {
            return this.Nombre + " " + this.Apellido;
        }

        [Required(ErrorMessage = "{0} requerido")]
        public int? TipoUserID { get; set; }
        
        public virtual Tipo_User Tipo_User { get; set; }
    }
}