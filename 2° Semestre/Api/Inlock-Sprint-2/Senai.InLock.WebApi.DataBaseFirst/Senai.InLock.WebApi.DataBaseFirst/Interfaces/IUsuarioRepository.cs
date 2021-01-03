using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IUsuarioRepository
    { /// <summary>
      /// Lista todos os estúdios
      /// </summary>
      /// <returns>Uma lista de estúdios</returns>
        List<Usuarios> Listar();

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado</returns>
        Usuarios BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        void Cadastrar(Usuarios novoUsuario);

        //Atualizar os estudios pelo corpo ou pelo ID;
        void Atualizar(int id, Usuarios attUsuario);

        //Deletar os estudios por Id;
        void Delete(int id);
    }
}
