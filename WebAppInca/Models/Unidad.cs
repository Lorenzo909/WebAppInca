using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Unidad
    {
        public Unidad()
        {
            Material = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string Simbolo { get; set; }
        public string Discripcion { get; set; }

        public virtual ICollection<Material> Material { get; set; }
    }
}
