using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int? ServicioId { get; set; }

        public virtual Servicio Servicio { get; set; }
    }
}
