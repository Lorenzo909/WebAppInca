using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Planilla = new HashSet<Planilla>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Planilla> Planilla { get; set; }
    }
}
