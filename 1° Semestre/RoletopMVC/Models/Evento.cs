using System;
using RoletopMVC.Enum;
using static RoletopMVC.Enum.StatusEventos;

namespace RoletopMVC.Models
{
    public class Evento
    {
         public  ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public Evento Eventos {get;set;}
        public double PrecoTotal {get;set;}
        public DateTime DataDoPedido {get; set;}
        public DateTime DiadoEvento {get;set;}
        public Serviços Serviços {get;set;}
       public string TipoEvento {get;set;}
        public uint Status {get;set;}
        public string NomeEvento {get;set;}
        public string Nome {get;set;}
        public double Preco {get;set;}
        public string Fotodeperfil {get;set;}
         public uint Privacidade {get;set;}

        
        public Evento()
        {
            this.Cliente = new Cliente();
            this.Serviços = new Serviços(); 
            this.TipoEvento = TipoEvento;
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE; 
            this.Privacidade = (uint) PrivacidadeEvento.Privado;
           
        }

    }
}