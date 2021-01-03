using Microsoft.EntityFrameworkCore;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {

        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Presenca attPresenca)
        {
            Presenca presencaBuscada = ctx.Presenca.Find(id);

            presencaBuscada.Situacao = attPresenca.Situacao;

            ctx.SaveChanges();
        }

        public Presenca BuscarporId(int id)
        {
            return ctx.Presenca.FirstOrDefault(p => p.IdPresenca == id);
        }

        public void Cadastar(Presenca novaPresenca)
        {
            ctx.Presenca.Add(novaPresenca);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Presenca presencaBuscado = ctx.Presenca.Find(id);

            ctx.Presenca.Remove(presencaBuscado);

            ctx.SaveChanges();
        }

        public List<Presenca> Listar()
        {
            return ctx.Presenca.Include(p => p.IdEventoNavigation).Include(p => p.IdUsuarioNavigation).ToList();
        }

        public void inscrição(Presenca novaPresenca)
        {
            ctx.Presenca.FirstOrDefault( P => P.IdUsuario == novaPresenca.IdUsuario && P.IdEvento == novaPresenca.IdEvento)null)
        }


    }
}
