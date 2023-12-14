using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Repositories;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly WebApiContext _context;
        private CategoriumRepository _categoriums;
        private CiudadRepository _ciudades;
        private ClienteRepository _clientes;
        private ColorRepository _colores;
        private ContactoRepository _contactos;
        private DepartamentoRepository _departamentos;
        private DetallePedidoRepository _detallespedidos;
        private DireccionRepository _direcciones;
        private EstadoPedidoRepository _estadospedidos;
        private InventarioRepository _inventarios;
        private PaisRepository _paises;
        private PedidoRepository _pedidos;
        private ProductoRepository _productos;
        private TipoMaterialRepository _tiposmateriales;
        private TipoPagoRepository _tipospagos;
        private TipoProductoRepository _tiposproductos;
        private TransaccionesRepository _transacciones;

        public ICategoriumRepository Categorias
        {
            get 
            {
                if (_categoriums == null)
                {
                    _categoriums = new CategoriumRepository(_context);
                }
                return _categoriums;
            }
        }
        public ICiudadRepository Ciudades
        {
            get 
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context);
                }
                return _ciudades;
            }
        }
        public IClienteRepository Clientes
        {
            get 
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context);
                }
                return _clientes;
            }
        }
        public IColorRepository Colores
        {
            get 
            {
                if (_colores == null)
                {
                    _colores = new ColorRepository(_context);
                }
                return _colores;
            }
        }
        public IContactoRepository Contactos
        {
            get 
            {
                if (_contactos == null)
                {
                    _contactos = new ContactoRepository(_context);
                }
                return _contactos;
            }
        }
        public IDepartamentoRepository Departamentos
        {
            get 
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }
        }
        public IDetallePedidoRepository DetallesPedidos
        {
            get 
            {
                if (_detallespedidos == null)
                {
                    _detallespedidos = new DetallePedidoRepository(_context);
                }
                return _detallespedidos;
            }
        }
        public IDireccionRepository Direcciones
        {
            get 
            {
                if (_direcciones == null)
                {
                    _direcciones = new DireccionRepository(_context);
                }
                return _direcciones;
            }
        }
        public IEstadoPedidoRepository EstadosPedidos
        {
            get 
            {
                if (_estadospedidos == null)
                {
                    _estadospedidos = new EstadoPedidoRepository(_context);
                }
                return _estadospedidos;
            }
        }
        public IInventarioRepository Inventarios
        {
            get 
            {
                if (_inventarios == null)
                {
                    _inventarios = new InventarioRepository(_context);
                }
                return _inventarios;
            }
        }
        public IPaisRepository Paises
        {
            get 
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;
            }
        }
        public IPedidoRepository Pedidos
        {
            get 
            {
                if (_pedidos == null)
                {
                    _pedidos = new PedidoRepository(_context);
                }
                return _pedidos;
            }
        }
        public IProductoRepository Productos
        {
            get 
            {
                if (_productos == null)
                {
                    _productos = new ProductoRepository(_context);
                }
                return _productos;
            }
        }
        public ITipoMaterialRepository TiposMateriales
        {
            get 
            {
                if (_tiposmateriales == null)
                {
                    _tiposmateriales = new TipoMaterialRepository(_context);
                }
                return _tiposmateriales;
            }
        }
        public ITipoPagoRepository TiposPagos
        {
            get 
            {
                if (_tipospagos == null)
                {
                    _tipospagos = new TipoPagoRepository(_context);
                }
                return _tipospagos;
            }
        }
        public ITipoProductoRepository TiposProductos
        {
            get 
            {
                if (_tiposproductos == null)
                {
                    _tiposproductos = new TipoProductoRepository(_context);
                }
                return _tiposproductos;
            }
        }
        public ITransaccionesRepository Transacciones
        {
            get 
            {
                if (_transacciones == null)
                {
                    _transacciones = new TransaccionesRepository(_context);
                }
                return _transacciones;
            }
        }

        public UnitOfWork(WebApiContext context)
        {
            _context = context;
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}