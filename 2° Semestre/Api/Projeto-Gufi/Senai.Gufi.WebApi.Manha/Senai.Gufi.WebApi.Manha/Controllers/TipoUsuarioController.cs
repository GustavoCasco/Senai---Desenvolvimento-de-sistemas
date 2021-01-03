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
    [Produces("application/jsom")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tiposuariorepository { get; set; }

        public TipoUsuarioController()
        {
            _tiposuariorepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(200, _tiposuariorepository.Listar());
        }

        [HttpGet("id")]
        public IActionResult GetporId(int id)
        {
            return StatusCode(200, _tiposuariorepository.BuscarporId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(TipoUsuario novoTipoUser)
        {
            _tiposuariorepository.Cadastar(novoTipoUser);
            return StatusCode(201, novoTipoUser);
        }

        [HttpPut("id")]
        public IActionResult Atualizar(int id, TipoUsuario attTipoUsuario)
        {
            try
            {
                _tiposuariorepository.Atualizar(id, attTipoUsuario);

                return StatusCode(204, attTipoUsuario);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {

            TipoUsuario user = _tiposuariorepository.BuscarporId(id);

            if (user != null)
            {
                _tiposuariorepository.Deletar(id);

                return Ok("Tipo Usuario deletado");
            }
            return NotFound("Nenhum Tipo usuario encontrado");
        }

    }
}