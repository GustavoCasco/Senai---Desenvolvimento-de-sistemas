using System;   

namespace McBonalds
{
    public class Cliente
    {
      //propriedades

     public string Nome; //Nome do cliente
     public string Endereço; //Endereço do cliente
     public string Telefone;// Telefone do cliente
     public string Senha;// Senha de acesso do cliente ao sistema
     public string Email; //Email do cliente e nome do usuario do sistema 
    public DateTime DataNascimento;// Data de Nascimento do cliente

    //construtores
    public Cliente(string nome, string telefone, string email){
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }





    }
}