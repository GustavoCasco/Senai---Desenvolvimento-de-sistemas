using System;
using System.Collections.Generic;
using RoletopMVC.Models;


namespace RoletopMVC.ViewModels
{
    public class EventosViewModel : BaseViewModel
    {
          public List<Evento> Eventos {get;set;}
          public List<Serviços> Serviços {get;set;}
        public Cliente Cliente {get;set;}
         public string NomeCliente {get;set;}
         public string TipoEvento {get;set;}
         public string FotoEvento {get;set;}
       

        
        public EventosViewModel()
        {
        this.Eventos = new List<Evento>();
        this.Cliente = new Cliente();  
        this.NomeCliente = "Jovem";   
        this.Serviços =  new List<Serviços>(); 
        this.TipoEvento = TipoEvento;
        }


    }
}