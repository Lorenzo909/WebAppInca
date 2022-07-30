using System;
using System.Collections.Generic;


namespace WebAppInca.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Herramienta = new HashSet<Herramienta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Herramienta> Herramienta { get; set; }
    }
}
