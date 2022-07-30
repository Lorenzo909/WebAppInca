using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Factura
    {
        public int Id { get; set; }
        public string Consecutivo { get; set; }
        public decimal Monto { get; set; }
        public DateTime? FechaEmicion { get; set; }
        public int CuentaId { get; set; }
        public int ProveedorId { get; set; }

        public virtual Cuenta Cuenta { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
