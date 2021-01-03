using System;
using EscoladeRock.Interface;

namespace EscoladeRock.models
{
    
    
        public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
        {
            public bool TocarSolo()
            {
                System.Console.WriteLine("Mantendo a melodia do teclado");
                return true;
            }

            public bool TocarAcorde()
            {
                System.Console.WriteLine("Tocando Acorde do teclado");
                return true;
            }
        
    }
}
