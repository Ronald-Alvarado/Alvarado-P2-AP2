using System;
using System.ComponentModel.DataAnnotations;

namespace Alvarado_P2_AP2.Models{
    public class CobrosDetalle
    {        
        [Key]
        public int CobroDetalleId { get; set; }
        public int CobroId { get; set; }
        public int VentaId { get; set; }
        public float Cobrado { get; set; }

        public virtual Cobros Cobro { get; set; }
        public virtual Ventas Venta { get; set; }

        
    }
}