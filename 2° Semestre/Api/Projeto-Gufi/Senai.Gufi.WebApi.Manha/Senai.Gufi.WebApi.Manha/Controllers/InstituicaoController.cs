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
    public class InstituicaoController : ControllerBase
    {
        private IInstituiçãoRepository _instituicaoRepsoitory { get; set; }

        public InstituicaoController()
        {
            _instituicaoRepsoitory = new InstitucaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_instituicaoRepsoitory.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_instituicaoRepsoitory.BuscarporId(id));
        }

        [HttpPost]
        public IActionResult Post(Instituicao novoInstituicao)
        {
            _instituicaoRepsoitory.Cadastra(novoInstituicao);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Instituicao instituicaoAtualizado)
        {
            try
            {
                _instituicaoRepsoitory.Atualizar(id, instituicaoAtualizado);

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
            _instituicaoRepsoitory.Deletar(id);

            return StatusCode(204);
        }
    }
}