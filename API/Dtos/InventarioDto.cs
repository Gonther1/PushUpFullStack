using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto
    {
        public int Id { get; set; }
        public int CantidadAlmacenada { get; set; }

        public string? Descripcion { get; set; }
    }
}