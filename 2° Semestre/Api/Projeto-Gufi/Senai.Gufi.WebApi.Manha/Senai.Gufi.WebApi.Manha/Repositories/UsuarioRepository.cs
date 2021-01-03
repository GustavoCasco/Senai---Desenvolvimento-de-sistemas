using Microsoft.EntityFrameworkCore;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Usuario attUser)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            usuarioBuscado.NomeUsuario = attUser.NomeUsuario;

            usuarioBuscado.Senha = attUser.Senha;

            usuarioBuscado.Email = attUser.Email;

            usuarioBuscado.DataCadastro = attUser.DataCadastro;

            usuarioBuscado.Genero = attUser.Genero;

        }

        public Usuario BuscarporId(int id)
        {
            return ctx.Usuario.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastar(Usuario novoUser)
        {
            ctx.Usuario.Add(novoUser);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario userBuscado = ctx.Usuario.Find(id);

            ctx.Usuario.Remove(userBuscado);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.Include(u => u.IdTipousuarioNavigation).ToList();
        }

        public Usuario BuscarEmaileSenha(string email, string senha)
        {
            return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
