using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using Senai.InLock.WebApi.DataBaseFirst.Repositories;

namespace Senai.InLock.WebApi.DataBaseFirst.Controllers
{
    [Route("api/[controller]")]

    [Produces("application/json")]

    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuariosController()
        {
            
           _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get (Usuarios user)
        {
           return Ok(_usuarioRepository.Listar());
        }

        [HttpGet("id")]
        public IActionResult GetporId (int id, Usuarios user)
        {
            return Ok(_usuarioRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post (Usuarios adduser)
        {
            _usuarioRepository.Cadastrar(adduser);
            return StatusCode(201);
        }

        [HttpPut]
        public IActionResult Put (int id, Usuarios attUsuario)
        {
            _usuarioRepository.Atualizar(id , attUsuario);
            return Ok($"Usuario {attUsuario.IdUsuario} atualizado com sucesso ");
        }

        [HttpDelete]
        public IActionResult Delete (int id)
        {
            _usuarioRepository.Delete(id);
            return Ok("Usuario deletado com sucesso");
        }
    }
}