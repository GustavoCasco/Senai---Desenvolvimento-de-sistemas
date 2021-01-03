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
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUusariorepository;

        public TipoUsuarioController()
        {
            _tipoUusariorepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get(TiposUsuario tipouser)
        {
            return Ok(_tipoUusariorepository.Listar());
        }

        [HttpGet("id")]
        public IActionResult GetporId(int id, TiposUsuario tipouser)
        {
            return Ok(_tipoUusariorepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(TiposUsuario TipoAdd)
        {
            _tipoUusariorepository.Cadastrar(TipoAdd);
            return StatusCode(201);
        }


        [HttpPut]
        public IActionResult Put(int id ,TiposUsuario attTipo)
        {
            _tipoUusariorepository.Atualizar(id, attTipo);
            return Ok($"Jogo {attTipo.IdTipoUsuario} atualizado com sucesso ");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _tipoUusariorepository.Delete(id);
            return Ok("Tipo Usuario deletado com sucesso");
        }
    }
}












