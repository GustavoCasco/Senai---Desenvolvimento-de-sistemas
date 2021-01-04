using System;
using System.Collections.Generic;
using System.Text;

namespace AppTower.Model
{
    public class Jogo
    {
        public int id { get; set; }
        public string selecaoCasa { get; set; }
        public string selecaoVisitante { get; set; }
        public int placarCasa { get; set; }
        public int placarVisitante { get; set; }
        //add mais 2 atributos
        public DateTime data { get; set; }
        public string estadio { get; set; }

        public override string ToString()
        {
            return $"{selecaoCasa} { placarCasa} X {selecaoVisitante} {placarVisitante}";

        }
    }
}
