using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo de ContraBaixo");
            return true;
        }

        public bool TocarAcorde()
        {
            System.Console.WriteLine("Tocando Acorde do ContraBaixo");
            return true;
        }
    }
}