using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class DireccionDto
    {
        public int Id { get; set; }
        public string LineaDireccion1 { get; set; } = null!;

        public string? LineaDireccion2 { get; set; }

        public string? CodigoPostal { get; set; }

        public int? IdCiudadFk { get; set; }
    }
}