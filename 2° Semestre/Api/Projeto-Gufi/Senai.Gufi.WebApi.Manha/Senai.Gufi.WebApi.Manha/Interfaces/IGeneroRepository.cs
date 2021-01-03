using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IGeneroRepository
    {
        List<Generos> Listar();

        void Cadastrar(Generos novoGenero);

        void Deletar(int id);

        void Atualizar(int id, Generos attGenero);

        Generos BuscarporId(int id);
    }
}
