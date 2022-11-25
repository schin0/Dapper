﻿using Domain.Filters.Veiculo;
using Domain.Models.Veiculo;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;

namespace CrudDapper.Controllers
{
    [Route("api/[controller]")]
    public class VeiculoController : Controller
    {
        // TODO: ver exemplo na notificação para model ser request e nao ir direto pro repository igual vem na controller
        // TODO: estudar automapper
        // TODO: colocar testes unitários no projeto
        private readonly IVeiculoService _veiculoService;

        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Veiculo model)
        {
            return Ok(_veiculoService.Insert(model));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Veiculo model)
        {
            return Ok(_veiculoService.Update(model));
        }

        [HttpDelete("{id},{tenantId}")]
        public IActionResult Delete(int id, Guid tenantId)
        {
            return Ok(_veiculoService.Delete(id, tenantId));
        }

        [HttpGet("{id},{tenantId}")]
        public IActionResult Get(int id, Guid tenantId)
        {
            return Ok(_veiculoService.GetById(id, tenantId));
        }
        
        [HttpGet]
        public IActionResult List(FiltroVeiculo filtro)
        {
            return Ok(_veiculoService.List(filtro));
        }

    }
}
