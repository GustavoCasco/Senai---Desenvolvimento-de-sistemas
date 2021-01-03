using ProjetoFilmes.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFilmes.Interfaces
{
    interface IFilmeRepository
    {
        /// <summary>
        /// Lista todos os filmes
        /// </summary>
        /// <returns>Retorna uma lista de filmes</returns>
        List<Filmes> Listar();

        /// <summary>
        /// Busca um filme através do seu ID
        /// </summary>
        /// <param name="idBuscar">ID do filme que será buscado</param>
        /// <returns>Retorna um filme buscado</returns>
        Filmes BuscarPorId(int idBuscar);

        /// <summary>
        /// Cadastra um novo filme
        /// </summary>
        /// <param name="novoFilme">Objeto com as informações que serão cadastradas</param>
        void Cadastrar(Filmes novoFilme);

        /// <summary>
        /// Atualiza um filme existente
        /// </summary>
        /// <param name="idAtualizar">ID do filme que será atualizado</param>
        /// <param name="filmeAtualizado">Objeto com as novas informações</param>
        void Atualizar(int idAtualizar, Filmes filmeAtualizado);

        /// <summary>
        /// Deleta um filme existente
        /// </summary>
        /// <param name="idDeletar">ID do filme que será deletado</param>
        void Deletar(int idDeletar);
    }
}
