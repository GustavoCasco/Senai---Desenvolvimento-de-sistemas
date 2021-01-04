namespace RoletopMVC.Models
{
    public class Serviços 
    {
        public string Nome {get; set;}
        public double Preco {get;set;}
         public Serviços ()
        {

        }

        public Serviços(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}