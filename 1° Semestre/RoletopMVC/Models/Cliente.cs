using System;

namespace RoletopMVC.Models
{
    public class Cliente
    {
        public string Email {get; set;}
        public string Senha {get; set;}
        public string Nome {get;set;}
        public string Telefone {get;set;}
        public string Cpf {get;set;}
        public DateTime DataNascimento {get;set;}
        public uint TipoUsuario {get;set;}

        public Cliente ()
        {

        }

        public Cliente ( string Nome, string Senha,  string Email, string Telefone, string Cpf, DateTime DataNascimento)
        {
            this.Email = Email;
            this.Senha = Senha;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
        }
    }
}