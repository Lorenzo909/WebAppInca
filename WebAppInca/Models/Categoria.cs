using System;
using System.Collections.Generic;


namespace WebAppInca.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Material = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Material> Material { get; set; }
    }
}
