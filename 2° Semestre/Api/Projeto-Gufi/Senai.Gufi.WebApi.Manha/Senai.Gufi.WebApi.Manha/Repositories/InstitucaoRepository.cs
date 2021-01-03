using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class InstitucaoRepository : IInstituiçãoRepository
    {
        GufiContext ctx = new GufiContext();
        
        public void Atualizar(int id, Instituicao attInstituicao)
        {
            Instituicao instituicaoBuscado = ctx.Instituicao.Find(id);

            instituicaoBuscado.NomeFantasia = attInstituicao.NomeFantasia;

            instituicaoBuscado.Cnpj = attInstituicao.Cnpj;

            instituicaoBuscado.Endereco = attInstituicao.Endereco;

            ctx.SaveChanges();
        }

        public Instituicao BuscarporId(int id)
        {
            return ctx.Instituicao.FirstOrDefault(i => i.IdInstituicao == id);

        }

        public void Cadastra(Instituicao novaInstituicao)
        {
            ctx.Instituicao.Add(novaInstituicao);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Instituicao instituicaoBuscado = new Instituicao();

            ctx.Instituicao.Remove(instituicaoBuscado);

            ctx.SaveChanges();
        }

        public List<Instituicao> Listar()
        {
            return ctx.Instituicao.ToList();
        }

     
    }
}
