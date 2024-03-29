﻿using System;
using System.Collections.Generic;

namespace WebAppInca.Models
{
    public partial class Planilla
    {
        public int Id { get; set; }
        public DateTime? FechaPago { get; set; }
        public int Horas { get; set; }
        public decimal? PrecioHora { get; set; }
        public decimal? Pago { get; set; }
        public int EmpleadoId { get; set; }
        public int PuestoId { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
