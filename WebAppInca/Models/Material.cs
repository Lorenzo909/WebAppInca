using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Material
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Medida { get; set; }
        public int UnidadId { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Unidad Unidad { get; set; }
    }
}
