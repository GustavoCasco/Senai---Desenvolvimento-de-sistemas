using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    interface IFilmeRepositiory
    {
        List<FilmeDomain> Listar();

        void AtualizarCorpo(FilmeDomain filmesnovos);

        void AtualizarUrl(int id, FilmeDomain filmesnovos);

        void Delete(int id);

        void Cadastrar(FilmeDomain filmenovo, int id);

        FilmeDomain BuscarporId(FilmeDomain filmenovo, int id );

       

       
    }
}
