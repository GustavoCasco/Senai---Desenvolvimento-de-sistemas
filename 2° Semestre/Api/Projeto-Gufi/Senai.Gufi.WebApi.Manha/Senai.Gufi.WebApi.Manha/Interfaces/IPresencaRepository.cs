using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IPresencaRepository
    {
        List<Presenca> Listar();

        void Atualizar(int id, Presenca attPresenca);

        void Cadastar(Presenca novaPresenca);

        void Deletar(int id);

        Presenca BuscarporId(int id);

        void inscrição (Presenca novaPresenca)
    }
}
