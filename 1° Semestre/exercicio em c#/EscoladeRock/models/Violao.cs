using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{
    public class Violao : InstrumentoMusical, IHarmonia
    {
        public bool TocarAcorde()
        {
            System.Console.WriteLine("Tocando acorde de Violão");
            return true;
        }
    }


}