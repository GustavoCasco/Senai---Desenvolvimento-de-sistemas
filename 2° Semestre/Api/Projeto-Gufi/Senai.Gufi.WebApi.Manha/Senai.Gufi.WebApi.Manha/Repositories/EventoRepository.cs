using Microsoft.EntityFrameworkCore;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Evento EventoAtualizado)
        {
            Evento eventoBuscado = ctx.Evento.Find(id);

            eventoBuscado.NomeEvento = EventoAtualizado.NomeEvento;

            eventoBuscado.Presenca = EventoAtualizado.Presenca;

            eventoBuscado.Descricao = EventoAtualizado.Descricao;

            eventoBuscado.AcessoLivre = EventoAtualizado.AcessoLivre;

            eventoBuscado.DataEvento = EventoAtualizado.DataEvento;
        }

        public Evento BuscarPorId(int id)
        {
            return ctx.Evento.FirstOrDefault(b => b.IdEvento == id);
        }

        public void Cadastrar(Evento novoEvento)
        {
            ctx.Evento.Add(novoEvento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Evento eventoBuscado = ctx.Evento.Find(id);

            ctx.Evento.Remove(eventoBuscado);

            ctx.SaveChanges();
        }

        public List<Evento> Listar()
        {
            return ctx.Evento.Include(e => e.IdInstituicaoNavigation).Include(e => e.IdTipoEventoNavigation).ToList();
        }
    }
}
