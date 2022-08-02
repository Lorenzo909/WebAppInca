using System;
using System.Collections.Generic;


namespace WebAppInca.Models
{
    public partial class Herramienta
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int TipoHerranientaId { get; set; }
        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual TipoHerramienta TipoHerranienta { get; set; }
    }
}
