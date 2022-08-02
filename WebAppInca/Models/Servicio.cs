using System;
using System.Collections.Generic;

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
