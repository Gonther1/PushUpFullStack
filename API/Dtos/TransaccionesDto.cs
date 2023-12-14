using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class TransaccionesDto
    {
        public int Id { get; set; }
        public DateTime? FechaTransaccion { get; set; }

        public double? MontoTotal { get; set; }

        public int? IdPedidoFk { get; set; }

        public int? IdTipoPagoFk { get; set; }
    }
}