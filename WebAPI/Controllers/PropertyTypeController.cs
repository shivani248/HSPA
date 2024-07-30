﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Dtos;
using WebAPI.Interfaces;

namespace WebAPI.Controllers
{
    public class PropertyTypeController :BaseController
    {

        private readonly InterfaceUnitofWork uow;
        private readonly IMapper mapper;

        public PropertyTypeController(InterfaceUnitofWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        // GET api/propertytype/list
        [HttpGet("list")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPropertyTypes()
        {
            var PropertyTypes = await uow.PropertyTypeRepository.GetPropertyTypesAsync();
            var PropertyTypesDto = mapper.Map<IEnumerable<KeyValuePairDto>>(PropertyTypes);
            return Ok(PropertyTypesDto);
        }
    }

}
