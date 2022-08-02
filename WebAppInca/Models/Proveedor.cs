using System;
using System.Collections.Generic;

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
