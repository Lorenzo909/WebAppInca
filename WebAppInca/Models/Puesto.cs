using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
