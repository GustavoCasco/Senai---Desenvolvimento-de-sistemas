using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter ritmo do tambor");
            return true;
        }
    }
}