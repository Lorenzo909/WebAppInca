using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppInca.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string CedJuridica { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
