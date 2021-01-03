using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repository
{
    class UsuarioRepository
    {
        private static List<Usuario> user;

        public static int cont = 1;


        public UsuarioRepository()
        {

            if (user == null)
            {
                user = new List<Usuario>();
            }
        }

        public void adicionar(Usuario usuario)
        {
            usuario.id = cont;

            user.Add(usuario);
            cont++;
        }
        public List<Usuario> buscarTodos()
        {
            return user;
        }

       

        public void AtualizarTodos(Usuario usuario)
        {
            Usuario u = user.Find(a => a.id == usuario.id);
            user[user.IndexOf(u)] = usuario;
        }

        public void deletar(int id)
        {
            Usuario usuario = user.Find(b => b.id == id);
            user.Remove(usuario);
        }
    }
}
