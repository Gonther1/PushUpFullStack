using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class PaisRepository : GenericRepository<Pai>, IPaisRepository
    {
        private readonly WebApiContext _context;
    
        public PaisRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}