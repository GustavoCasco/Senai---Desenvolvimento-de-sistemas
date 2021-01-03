using System;

namespace Ex1
{
    public class AgendaTelefonica
    {
        private string _Nome;
        private string _Telefone;
        private string _DataNascimento;

        public string Nome
        {
            get { return _Nome; }
        }
        public string Telefone
        {
            get { return _Telefone; }
        }
        public string DataNascimento
        {
            get { return _DataNascimento; }
        }

        public AgendaTelefonica (string nome, string telefone, string datanascimento)
        {
            this._Nome = nome;
            this._Telefone = telefone;
            this._DataNascimento = datanascimento;

        }
    }
}