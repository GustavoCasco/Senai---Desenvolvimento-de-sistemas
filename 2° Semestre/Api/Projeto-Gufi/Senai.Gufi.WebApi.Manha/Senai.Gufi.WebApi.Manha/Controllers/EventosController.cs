using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using Senai.Gufi.WebApi.Manha.Repositories;

namespace Senai.Gufi.WebApi.Manha.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private IEventoRepository _eventoRepository { get; set; }

        public EventosController()
        {
            _eventoRepository = new EventoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eventoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_eventoRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Evento novoEvento)
        {
            _eventoRepository.Cadastrar(novoEvento);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Evento EventoAtualizado)
        {
            try
            {
                _eventoRepository.Atualizar(id, EventoAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _eventoRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}