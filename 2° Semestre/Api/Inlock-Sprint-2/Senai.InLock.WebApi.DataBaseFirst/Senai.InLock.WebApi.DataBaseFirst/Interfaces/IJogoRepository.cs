using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IJogoRepository  
    {
        /// <summary> /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios</returns>
        List<Jogos> Listar();

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado</returns>
        Jogos BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        void Cadastrar(Jogos novoJogo);

        //Atualizar os estudios pelo corpo ou pelo ID;
        void Atualizar(int id , Jogos attJogo);

        //Deletar os estudios por Id;
        void Delete(int id);
 
    }
}
