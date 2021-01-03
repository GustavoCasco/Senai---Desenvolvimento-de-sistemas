using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da bateria");
            return true;
        }
    }
}