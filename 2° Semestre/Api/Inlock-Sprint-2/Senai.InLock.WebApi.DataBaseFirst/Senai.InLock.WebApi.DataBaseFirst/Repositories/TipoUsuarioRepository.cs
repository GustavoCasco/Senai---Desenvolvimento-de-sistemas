using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id , TiposUsuario atttipoUsuario)
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuario.Find(id);

            tipoUsuarioBuscado.Titulo = atttipoUsuario.Titulo;

            ctx.TiposUsuario.Update(atttipoUsuario);

            ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Cadastrar(TiposUsuario novotipoUsuario)
        {
            ctx.TiposUsuario.Add(novotipoUsuario);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuario.Find(id);
            ctx.TiposUsuario.Remove(tipoUsuarioBuscado);
            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuario.ToList();
        }
    }
}
