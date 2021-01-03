using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuario> Listar();

        void Atualizar(int id, Usuario attUser);

        void Deletar(int id);

        void Cadastar(Usuario novoUser);

        Usuario BuscarporId(int id);

        Usuario BuscarEmaileSenha(string email, string senha);
    }
}
