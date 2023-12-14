using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class InventarioRepository : GenericRepository<Inventario>, IInventarioRepository
    {
        private readonly WebApiContext _context;
    
        public InventarioRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}