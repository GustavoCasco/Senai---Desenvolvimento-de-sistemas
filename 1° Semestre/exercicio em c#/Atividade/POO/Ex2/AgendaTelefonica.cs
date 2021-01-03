using System;

namespace Ex2
{

    public class AgendaTelefonica
    {
        private string _Nome;
        private string _Telefone;
        private string _DataNascimento;

        private string _Email;

        public string Nome
        {
            get { return _Nome; }
            set {this._Nome = value;}
        }
        public string Telefone
        {
            get { return _Telefone; }
            set { this._Telefone = value;}
        }
        public string DataNascimento
        {
            get { return _DataNascimento; }
            set { this._Telefone = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { this._Email = value; }
        }
        public AgendaTelefonica(string nome, string telefone, string datanascimento, string email)
        {
            this._Nome = nome;
            this._Telefone = telefone;
            this._DataNascimento = datanascimento;
            this._Email = email;


        }
    
    }
}