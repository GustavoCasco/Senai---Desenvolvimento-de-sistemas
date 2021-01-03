using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using senai.Filmes.WebApi.Repositories;

namespace senai.Filmes.WebApi.Controllers
{
    [Route("api/[controller]")]

    [Produces("application/json")]

    [ApiController]
    public class FilmeController : ControllerBase
    {

        private IFilmeRepositiory filmeRepository { get; set; }

        public FilmeController()
        {
            filmeRepository = new FilmeRepository();
        }

        [HttpGet]
        public IEnumerable<FilmeDomain> Get()
        {
            // Faz a chamada para o método .Listar();
            return filmeRepository.Listar();
        }

        [HttpPost]
        public IActionResult Post(FilmeDomain filmenvo, int id)
        {
            // Faz a chamada para o método .Cadastrar();
            filmeRepository.Cadastrar(filmenvo, id);

            // Retorna um status code 201 - Created
            return StatusCode(201);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            FilmeDomain filmebuscado = filmeRepository.BuscarporId(id);

            // Verifica se nenhum gênero foi encontrado
            if (filmebuscado == null)
            {
                // Caso não seja encontrado, retorna um status code 404 com a mensagem personalizada
                return NotFound("Nenhum gênero encontrado");
            }

            // Caso seja encontrado, retorna o gênero buscado
            return Ok(filmebuscado);
        }

        [HttpPut("{id}")]
        public IActionResult PutIdCorpo(FilmeDomain filmeatualizado, int id)
        {

            filmeRepository.AtualizarUrl(filmeatualizado, id);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método .Deletar();
            filmeRepository.Delete(id);

            // Retorna um status code com uma mensagem personalizada
            return Ok("Gênero deletado");
        }


    }
}