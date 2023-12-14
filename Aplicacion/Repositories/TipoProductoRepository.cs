using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class TipoProductoRepository : GenericRepository<Tipoproducto>, ITipoProductoRepository
    {
        private readonly WebApiContext _context;
    
        public TipoProductoRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}