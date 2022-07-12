using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppInca.Models
{
    public partial class Proyecto
    {
        public int Id { get; set; }
        public string Contratacion { get; set; }
        public string NombreProyecto { get; set; }
        public decimal MontoProyecto { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public decimal GastoMaterial { get; set; }
        public decimal GastoManoObra { get; set; }
        public decimal? Utilidad { get; set; }
    }
}
