using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int? IdDireccionFk { get; set; }

        public int? IdContactoFk { get; set; }
    }
}