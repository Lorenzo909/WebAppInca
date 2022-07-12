using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppInca.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Contacto = new HashSet<Contacto>();
        }

        public int Id { get; set; }
        public string TipoServ { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Contacto> Contacto { get; set; }
    }
}
