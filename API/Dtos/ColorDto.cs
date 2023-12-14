using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ColorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}