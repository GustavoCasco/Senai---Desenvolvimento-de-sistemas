using System;


namespace MataODragao.Models
{
    public class Guerreiro
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CidadeNatal { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public string FerramentadeProtecao { get; set; }
        public string FerramentadeAtaque { get; set; }

        public int Forca { get; set; }
        public int Destreza{ get; set; }
        public int Inteligencia{ get; set; }
        public int Vida {get ; set;}


    }
}