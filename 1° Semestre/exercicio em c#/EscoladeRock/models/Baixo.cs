using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do baixo");
            return true;
        }

        public bool TocarAcorde()
        {
            System.Console.WriteLine("Tocando acordes de Baixo");
            return true;
        }
    }
}