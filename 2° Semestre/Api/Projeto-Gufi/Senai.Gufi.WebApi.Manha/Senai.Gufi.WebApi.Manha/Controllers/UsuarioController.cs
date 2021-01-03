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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController ()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get ()
        {
            return StatusCode(200, _usuarioRepository.Listar());
        }

        [HttpGet("id")]
        public IActionResult GetporId(int id )
        {
            return StatusCode(200, _usuarioRepository.BuscarporId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUser)
        {
            _usuarioRepository.Cadastar(novoUser);
            return StatusCode(201, novoUser);
        }

        [HttpPut("id")]
        public IActionResult Atualizar (int id, Usuario attUsuario)
        {
            try
            {
                _usuarioRepository.Atualizar(id, attUsuario);

                return StatusCode(204, attUsuario);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("id")]
        public IActionResult Delete (int id)
        {

            Usuario user = _usuarioRepository.BuscarporId(id);

            if(user != null)
            {
                _usuarioRepository.Deletar(id);

                return Ok("Usuario deletado");
            }
            return NotFound("Nenhum usuario encontrado");
        }
    }
}