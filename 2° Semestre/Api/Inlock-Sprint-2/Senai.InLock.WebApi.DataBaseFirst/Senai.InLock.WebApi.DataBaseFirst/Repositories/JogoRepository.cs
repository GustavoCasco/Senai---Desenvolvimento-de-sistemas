using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id , Jogos attJogo)
        {
            Jogos jogobuscado = ctx.Jogos.Find(id);

            jogobuscado.NomeJogo = attJogo.NomeJogo;

            ctx.Jogos.Update(attJogo);

            ctx.SaveChanges();
        }

        public Jogos BuscarPorId(int id)
        {
            return ctx.Jogos.FirstOrDefault(e => e.IdJogo == id);

        }

        public void Cadastrar(Jogos novoJogo)
        {
            ctx.Jogos.Add(novoJogo);

            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Jogos jogosbuscado = ctx.Jogos.Find(id);
            ctx.Remove(jogosbuscado);
            ctx.SaveChanges();
        }

        public List<Jogos> Listar()
        {
            return ctx.Jogos.ToList();
        }
    }
}
