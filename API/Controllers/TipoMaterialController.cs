using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class TipoMaterialController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TipoMaterialController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoMaterialDto>>> Get()
        {
            var entity = await _unitOfWork.TiposMateriales.GetAllAsync();
            return _mapper.Map<List<TipoMaterialDto>>(entity);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Tipomaterial>> Post(TipoMaterialDto entityDto)
        {
            var entity = _mapper.Map<Tipomaterial>(entityDto);
        /*
            if (entity.FechaCreacion == DateTime.MinValue)
            {
                entity.FechaCreacion = DateTime.Now;
                entityDto.FechaCreacion = DateTime.Now;
            }
            if (entity.FechaModificacion == DateTime.MinValue)
            {
                entity.FechaModificacion = DateTime.Now;
                entityDto.FechaModificacion = DateTime.Now;
            }
        */
            _unitOfWork.TiposMateriales.Add(entity);
            await _unitOfWork.SaveAsync();
            if (entity == null)
            {
                return BadRequest();
            }
            entityDto.Id = entity.Id;
            return CreatedAtAction(nameof(Post), new { id = entityDto.Id }, entityDto);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoMaterialDto>> Get(int id)
        {
            var entity = await _unitOfWork.TiposMateriales.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return _mapper.Map<TipoMaterialDto>(entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoMaterialDto>> Put(int id, [FromBody] TipoMaterialDto entityDto)
        {
            var entity = _mapper.Map<Tipomaterial>(entityDto);
            if (entity.Id == 0)
            {
                entity.Id = id;
            }
            if (entity.Id != id)
            {
                return BadRequest();
            }
            if (entity == null)
            {
                return NotFound();
            }
        /*
            if (entity.FechaCreacion == DateTime.MinValue)
            {
                entity.FechaCreacion = DateTime.Now;
                entityDto.FechaCreacion = DateTime.Now;
            }
            if (entity.FechaModificacion == DateTime.MinValue)
            {
                entity.FechaModificacion = DateTime.Now;
                entityDto.FechaModificacion = DateTime.Now;
            }
        */
            entityDto.Id = entity.Id;
            _unitOfWork.TiposMateriales.Update(entity);
            await _unitOfWork.SaveAsync();
            return entityDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
        {
            var entity = await _unitOfWork.TiposMateriales.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.TiposMateriales.Remove(entity);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}