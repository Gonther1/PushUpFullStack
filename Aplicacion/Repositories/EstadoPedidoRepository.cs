using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class EstadoPedidoRepository : GenericRepository<Estadopedido>, IEstadoPedidoRepository
    {
        private readonly WebApiContext _context;
    
        public EstadoPedidoRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}