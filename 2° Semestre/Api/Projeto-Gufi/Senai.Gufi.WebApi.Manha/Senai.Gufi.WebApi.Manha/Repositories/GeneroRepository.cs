using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Generos attGenero)
        {
            Generos generoBuscado = ctx.Generos.Find(id);

            generoBuscado.Nome = attGenero.Nome;

            generoBuscado.Filmes = attGenero.Filmes;

        }

        public Generos BuscarporId(int id)
        {
            return ctx.Generos.FirstOrDefault(g => g.IdGenero == id);
        }

        public void Cadastrar(Generos novoGenero)
        {
            ctx.Generos.Add(novoGenero);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Generos generoBuscado = ctx.Generos.Find(id);

            ctx.Generos.Remove(generoBuscado);

            ctx.SaveChanges();
        }

        public List<Generos> Listar()
        {
            return ctx.Generos.ToList();
        }
    }
}
