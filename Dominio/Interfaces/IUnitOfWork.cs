using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoriumRepository Categorias { get; }
        ICiudadRepository Ciudades { get; }
        IClienteRepository Clientes { get; }
        IColorRepository Colores { get; }
        IContactoRepository Contactos { get; }
        IDepartamentoRepository Departamentos { get; }
        IDetallePedidoRepository DetallesPedidos { get; }
        IDireccionRepository Direcciones { get; }
        IEstadoPedidoRepository EstadosPedidos { get; }
        IInventarioRepository Inventarios { get; }
        IPaisRepository Paises { get; }
        IPedidoRepository Pedidos { get; }
        IProductoRepository Productos { get; }
        ITipoMaterialRepository TiposMateriales { get; }
        ITipoPagoRepository TiposPagos { get; }
        ITipoProductoRepository TiposProductos { get; }
        ITransaccionesRepository Transacciones { get; }
        Task<int> SaveAsync();
    }
}