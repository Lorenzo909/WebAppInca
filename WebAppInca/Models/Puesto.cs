using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            Planilla = new HashSet<Planilla>();
        }

        public int Id { get; set; }
        public string Cargo { get; set; }

        public virtual ICollection<Planilla> Planilla { get; set; }
    }
}
