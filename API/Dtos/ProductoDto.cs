using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public double? PrecioUnd { get; set; }

        public int? CantidadVendida { get; set; }

        public int? IdCategoriaFk { get; set; }

        public int? IdTipoProductoFk { get; set; }

        public int? IdColorFk { get; set; }

        public int? IdTipoMaterialFk { get; set; }

        public int? IdInventarioFk { get; set; }
    }
}