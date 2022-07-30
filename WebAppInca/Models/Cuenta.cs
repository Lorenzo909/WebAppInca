using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
