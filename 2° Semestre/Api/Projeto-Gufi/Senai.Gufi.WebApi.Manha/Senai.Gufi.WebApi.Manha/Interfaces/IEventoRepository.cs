using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> Listar();

        void Cadastrar(Evento novoEvento);

        void Atualizar(int id, Evento EventoAtualizado);

        void Deletar(int id);

        Evento BuscarPorId(int id);
    }
}
