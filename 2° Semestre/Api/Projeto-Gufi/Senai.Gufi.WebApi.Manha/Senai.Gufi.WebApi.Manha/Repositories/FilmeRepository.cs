using Microsoft.EntityFrameworkCore;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class FilmeRepository : IFilmesRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Filmes attFilme)
        {
            Filmes filmesBuscado = ctx.Filmes.Find(id);

            filmesBuscado.Titulo = attFilme.Titulo;
            
        }

        public Filmes BuscarporId(int id)
        {
            return ctx.Filmes.FirstOrDefault(f => f.IdFilme == id);
        }

        public void Cadastro(Filmes novoFilme)
        {
            ctx.Filmes.Add(novoFilme);

            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Filmes filmesBuscado = ctx.Filmes.Find(id);

            ctx.Filmes.Remove(filmesBuscado);

            ctx.SaveChanges();
        }

        public List<Filmes> Listar()
        {
            return ctx.Filmes.Include(f => f.IdGeneroNavigation).ToList();
        }
    }
}
