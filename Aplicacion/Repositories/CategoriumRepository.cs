using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class CategoriumRepository : GenericRepository<Categorium>, ICategoriumRepository
    {
        private readonly WebApiContext _context;
    
        public CategoriumRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}