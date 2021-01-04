using System.Collections.Generic;
using RoletopMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace RoletopMVC.Repositories
{
    public class ServiçosRepository : RepositoryBase
    {
     
        private const string PATH = "Database/Serviços.csv";

        public double ObterPrecoDe(string nomeEventos)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeEventos))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Serviços> ObterTodos()
        {
            List<Serviços> serviços = new List<Serviços>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Serviços h = new Serviços();
                string [] dados = linha.Split(";");
                h.Nome = dados[0];
                h.Preco = double.Parse(dados[1]);
                serviços.Add(h);
            }

            return serviços;
        }
        
     
    }
 }
