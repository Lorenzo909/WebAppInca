using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class TipoHerramienta
    {
        public TipoHerramienta()
        {
            Herramienta = new HashSet<Herramienta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Herramienta> Herramienta { get; set; }
    }
}
