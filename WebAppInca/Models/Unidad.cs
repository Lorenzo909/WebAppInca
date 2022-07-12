using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
