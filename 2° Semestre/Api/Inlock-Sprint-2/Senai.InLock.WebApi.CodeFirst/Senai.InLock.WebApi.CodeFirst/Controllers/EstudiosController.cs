using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.CodeFirst.Domains;
using Senai.InLock.WebApi.CodeFirst.Interfaces;
using Senai.InLock.WebApi.CodeFirst.Repositories;

namespace Senai.InLock.WebApi.CodeFirst.Controllers
{
    /// <summary>
    /// Controller responsável pelos endpoints referentes aos estudios
    /// </summary>
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class EstudiosController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        public EstudiosController()
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estudioRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_estudioRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Estudios novoEstudio)
        {
            _estudioRepository.Cadastrar(novoEstudio);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Estudios estudioAtualizado)
        {
            _estudioRepository.Atualizar(id, estudioAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _estudioRepository.Deletar(id);

            return StatusCode(204);
        }

        [HttpGet("Jogos")]
        public IActionResult GetJogos()
        {
            return Ok(_estudioRepository.ListarJogos());
        }
    }
}