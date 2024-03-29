﻿using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.Contexts;
using ProjetoFilmes.Domains;
using ProjetoFilmes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFilmes.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        /// <summary>
        /// Instancia um novo contexto para utilizar os métodos do EF Core
        /// </summary>
        FilmesBDContext ctx = new FilmesBDContext();

        /// <summary>
        /// Atualiza um filme existente
        /// </summary>
        /// <param name="idAtualizar">ID do filme que será atualizado</param>
        /// <param name="filmeAtualizado">Objeto com as novas informações</param>
        public void Atualizar(int idAtualizar, Filmes filmeAtualizado)
        {
            Filmes filmeAtual = BuscarPorId(idAtualizar);

            if (filmeAtual != null)
            {
                filmeAtual.Titulo = filmeAtualizado.Titulo;
            }

            ctx.Filmes.Update(filmeAtual);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Busca um filme através do seu ID
        /// </summary>
        /// <param name="idBuscar">ID do filme que será buscado</param>
        /// <returns>Retorna um filme buscado</returns>
        public Filmes BuscarPorId(int idBuscar)
        {
            Filmes filmeBuscado = ctx.Filmes.Find(idBuscar);

            return filmeBuscado;
        }

        /// <summary>
        /// Cadastra um novo filme
        /// </summary>
        /// <param name="novoFilme">Objeto com as informações que serão cadastradas</param>
        public void Cadastrar(Filmes novoFilme)
        {
            ctx.Filmes.Add(novoFilme);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta um filme existente
        /// </summary>
        /// <param name="idDeletar">ID do filme que será deletado</param>
        public void Deletar(int idDeletar)
        {
            ctx.Filmes.Remove(BuscarPorId(idDeletar));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os filmes
        /// </summary>
        /// <returns>Retorna uma lista de filmes</returns>
        public List<Filmes> Listar()
        {
            return ctx.Filmes.Include(f => f.IdGeneroNavigation).ToList();
        }
    }
}
