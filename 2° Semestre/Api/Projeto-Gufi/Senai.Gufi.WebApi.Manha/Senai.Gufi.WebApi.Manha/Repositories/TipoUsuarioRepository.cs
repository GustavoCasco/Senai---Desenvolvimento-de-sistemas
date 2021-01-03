using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, TipoUsuario attTipoUser)
        {
            TipoUsuario tipoUserBuscado = ctx.TipoUsuario.Find(id);

            tipoUserBuscado.TituloTipoUsuario = attTipoUser.TituloTipoUsuario;
        }

        public TipoUsuario BuscarporId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(b => b.IdTipoUsuario == id);
        }

        public void Cadastar(TipoUsuario novoTipoUser)
        {
            ctx.TipoUsuario.Add(novoTipoUser);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario tipoUserBuscado = ctx.TipoUsuario.Find(id);

            ctx.TipoUsuario.Remove(tipoUserBuscado);

            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}
