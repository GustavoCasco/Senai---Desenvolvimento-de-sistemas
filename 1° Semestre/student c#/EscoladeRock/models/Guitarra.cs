using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{


    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Mantendo a melodia da Guitarra");
            return true;
        }

        public bool TocarAcorde()
        {
            System.Console.WriteLine("Tocando Acorde do Guitarra");
            return true;
        }
    }

}
