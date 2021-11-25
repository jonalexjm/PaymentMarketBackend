using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PaymentMarketBackend.Api.Responses;
using PaymentMarketBackend.Core.DTOs;
using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Exceptions;
using PaymentMarketBackend.Core.Interfaces.Services;
using PaymentMarketBackend.Core.QueryFilters;

namespace PaymentMarketBackend.Api.Controllers
{
    
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AnniosController : ControllerBase
    {
        private readonly IAnnioService _annioService;
        private readonly IMapper _mapper;
        public AnniosController(IAnnioService annioService,
                                IMapper mapper)
        {
            _annioService = annioService;
            _mapper = mapper;
        }
        // GET
        [HttpGet("GetAllAnnios")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<List<AnnioDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ApiResponse<List<AnnioDto>>))]
        //[FromQuery] sirve para decirle que los filters vienen por query string
        public async Task<IActionResult> GetAllAnnios([FromQuery]AnnioQueryFilter filters)
        {
            var annios = await _annioService.GetAllAnnio(filters);
            var anniosDto = _mapper.Map<List<AnnioDto>>(annios);
            var response = new ApiResponse<List<AnnioDto>>(anniosDto);
            return Ok(response);
        }
        
        [HttpGet("CreateAnnio")]
        
        public async Task<IActionResult> CreateAnnio(AnnioDto annioDto)
        {
            var annio = _mapper.Map<Annio>(annioDto);
            await _annioService.CreateAnnio(annio);

            // if (true)
            // {
            //     throw new BusinessExceptions("este es una excepcion de negocio")
            // }
            
            return Ok();
        }
        
        [HttpPut("UpdateAnnio")]
        public IActionResult UpdateAnnio()
        {
            
            return Ok();
        }
        
        [HttpDelete("DeleteAnnio")]
        public IActionResult DeleteAnnio()
        {
            
            return Ok();
        }
        
        
    }
}