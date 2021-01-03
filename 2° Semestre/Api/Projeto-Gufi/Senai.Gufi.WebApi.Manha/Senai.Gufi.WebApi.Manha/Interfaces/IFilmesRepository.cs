using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IFilmesRepository
    {
        List<Filmes> Listar();

        void Atualizar(int id, Filmes attFilme);

        void Delete(int id);

        void Cadastro(Filmes novoFilme);

        Filmes BuscarporId(int id);
    }
}
