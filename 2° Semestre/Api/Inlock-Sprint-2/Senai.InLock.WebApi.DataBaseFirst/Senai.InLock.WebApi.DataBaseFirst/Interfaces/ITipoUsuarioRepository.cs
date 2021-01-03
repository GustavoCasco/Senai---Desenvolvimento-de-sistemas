using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TiposUsuario> Listar();

    
        TiposUsuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        void Cadastrar(TiposUsuario novotipoUsuario);

        //Atualizar os estudios pelo corpo ou pelo ID;
        void Atualizar(int id , TiposUsuario atttipoUsuario);

        //Deletar os estudios por Id;
        void Delete(int id);
    }
}
