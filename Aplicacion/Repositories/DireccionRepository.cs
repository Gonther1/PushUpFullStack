using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class DireccionRepository : GenericRepository<Direccion>, IDireccionRepository
    {
        private readonly WebApiContext _context;
    
        public DireccionRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}