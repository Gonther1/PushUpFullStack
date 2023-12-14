using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class TransaccionesRepository : GenericRepository<Transaccione>, ITransaccionesRepository
    {
        private readonly WebApiContext _context;
    
        public TransaccionesRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}