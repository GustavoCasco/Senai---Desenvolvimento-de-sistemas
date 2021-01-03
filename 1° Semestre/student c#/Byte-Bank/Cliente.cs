namespace Byte_Bank
{
    public class Cliente
    {
        private string _Nome { get; set; }
        private string _Sobrenome { get; set; }
        private string _Cpf { get; set; }
        private string _Email { get; set; }
        private string _Senha { get; set; }



        //*Construtores */

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public Cliente(string nome, string cpf, string email)
        {
            _Nome = nome;
            _Cpf = cpf;
            _Email = email;
        }

        public bool TrocaSenha(string senha)
        {
            if ((senha.Length > 6) && (senha.Length < 16))
            {
                this._Senha = senha;
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}