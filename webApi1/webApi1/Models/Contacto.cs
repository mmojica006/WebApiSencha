using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webApi1.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [StringLength(50,MinimumLength =1)]
        public string Nombre { get; set; }
        [StringLength(50,MinimumLength =1)]
        public string Correo { get; set; }
        [StringLength(30,MinimumLength =1)]
        public string  Telefono { get; set; }
        [DefaultValue("true")]
        public bool Activo { get; set; }

    }
}