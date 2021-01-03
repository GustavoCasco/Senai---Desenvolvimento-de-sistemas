using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IInstituiçãoRepository
    {
        List<Instituicao> Listar();

        void Atualizar(int id, Instituicao attInstituicao);

        void Cadastra(Instituicao novaInstituicao);

        void Deletar(int id);

        Instituicao BuscarporId(int id);
     }
}
