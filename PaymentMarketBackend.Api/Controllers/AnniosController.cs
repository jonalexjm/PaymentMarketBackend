using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PaymentMarketBackend.Core.DTOs;
using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Exceptions;
using PaymentMarketBackend.Core.Interfaces.Services;

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
        
        public async Task<IActionResult> GetAllAnnios()
        {
            var annios = await _annioService.GetAllAnnio();
            var anniosDto = _mapper.Map<List<AnnioDto>>(annios);
            return Ok(new
            {
                anniosDto
            });
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