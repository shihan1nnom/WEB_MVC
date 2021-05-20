using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba_1.Models
{
    public class Tipo_User
    {
        [Key, Column(Order = 1)]
        public int TipoUserID { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Usuario { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Categoria { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Activo { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool TipoUser { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Sedes { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Ambientes { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Asignar { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool Consulta { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        public bool CopiaSeguridad { get; set; }
        
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}