using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        void Atualizar(int id, TipoUsuario attTipoUser);

        void Deletar(int id);

        void Cadastar(TipoUsuario novoTipoUser);

        TipoUsuario BuscarporId(int id);
    }
}
