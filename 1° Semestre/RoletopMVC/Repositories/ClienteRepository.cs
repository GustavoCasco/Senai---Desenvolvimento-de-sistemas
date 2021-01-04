using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RoletopMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace RoletopMVC.Repositories
{
        public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[]{PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH,linha);
            return true;
        }

        public Cliente ObterPor (string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email",item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    c.Email = ExtrairValorDoCampo("email",item);
                    c.Senha = ExtrairValorDoCampo("senha",item);
                    c.Nome = ExtrairValorDoCampo("nome",item);
                    c.Telefone = ExtrairValorDoCampo("telefone",item);
                    c.Cpf = ExtrairValorDoCampo("cpf", item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento",item));

                    return c;
                }
            }
            return null;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};email={cliente.Email};senha={cliente.Senha};nome={cliente.Nome};telefone={cliente.Telefone};cpf={cliente.Cpf};data_nascimento={cliente.DataNascimento}";
        }
    }
    }
