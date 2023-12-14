using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Dominio.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Categorium, CategoriumDto>()
            .ReverseMap();
            CreateMap<Ciudad, CiudadDto>()
            .ReverseMap();
            CreateMap<Cliente, ClienteDto>()
            .ReverseMap();
            CreateMap<Color, ColorDto>()
            .ReverseMap();
            CreateMap<Contacto, ContactoDto>()
            .ReverseMap();  
            CreateMap<Departamento, DepartamentoDto>()
            .ReverseMap();
            CreateMap<Detallepedido, DetallePedidoDto>()
            .ReverseMap();
            CreateMap<Direccion, DireccionDto>()
            .ReverseMap();
            CreateMap<Estadopedido, EstadoPedidoDto>()
            .ReverseMap();
            CreateMap<Inventario, InventarioDto>()
            .ReverseMap();
            CreateMap<Pai, PaisDto>()
            .ReverseMap();
            CreateMap<Pedido, PedidoDto>()
            .ReverseMap();
            CreateMap<Producto, ProductoDto>()
            .ReverseMap();
            CreateMap<Tipomaterial, TipoMaterialDto>()
            .ReverseMap();
            CreateMap<Tipopago, TipoPagoDto>()
            .ReverseMap();
            CreateMap<Tipoproducto, TipoProductoDto>()
            .ReverseMap();
            CreateMap<Transaccione, TransaccionesDto>()
            .ReverseMap();
        }
    }
}