using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    /// <summary>
    /// Repositório dos Estúdios
    /// </summary>
    public class EstudioRepository : IEstudioRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        InLockContext ctx = new InLockContext();

        /// <summary>
        /// Busca um estúdio através do ID
        /// </summary>
        /// <param name="id">ID do estúdio que será buscado</param>
        /// <returns>Um estúdio buscado</returns>
        public Estudios BuscarPorId(int id)
        {
            // Retorna o primeiro estúdio encontrado para o ID informado
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
        }

        /// <summary>
        /// Cadastra um novo estúdio
        /// </summary>
        /// <param name="novoEstudio">Objeto novoEstudio que será cadastrado</param>
        public void Cadastrar(Estudios novoEstudio)
        {
            // Adiciona este novoEstudio
            ctx.Estudios.Add(novoEstudio);
            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os estúdios
        /// </summary>
        /// <returns>Uma lista de estúdios</returns>
        public List<Estudios> Listar()
        {
            // Retorna uma lista com todas as informações dos estúdios
            return ctx.Estudios.ToList();
        }

        public void Atualizar(int id , Estudios attestudio)
        {
            Estudios estudioBuscado = ctx.Estudios.Find(id);

            estudioBuscado.NomeEstudio = attestudio.NomeEstudio;

            ctx.Estudios.Update(attestudio);

            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Estudios estudiobuscado = ctx.Estudios.Find(id);

            ctx.Estudios.Remove(estudiobuscado);
            //Salvar as modificações
            ctx.SaveChanges();
        }

  
    }
}
