using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id , Usuarios attUsuario)
        {
            Usuarios usuariobuscado = ctx.Usuarios.Find(id);

            usuariobuscado.Email = attUsuario.Email;

            usuariobuscado.Senha = attUsuario.Senha;

            usuariobuscado.IdTipoUsuario = attUsuario.IdTipoUsuario;

            ctx.Usuarios.Update(attUsuario);

            ctx.SaveChanges();
           
        }

        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Usuarios usuariobuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuariobuscado);

            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
           return ctx.Usuarios.ToList();
        }
    }
}
