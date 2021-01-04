
using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    
         public class DashboardViewModel : BaseViewModel
    {
        public List<Evento> Evento {get;set;}
        public List<Evento> Eaprovado {get;set;}
        public List<Evento> Erecusados {get;set;}
        public List<Evento> Ependentes {get;set;}
       public List<Serviços> Serviços {get;set;}
        public uint EventosAprovados {get;set;}
        public uint EventosReprovados {get;set;}
        public uint EventosPendentes {get;set;}


        public DashboardViewModel()
        {
            this.Evento = new List<Evento>();
            this.Serviços = new List<Serviços>();
        }
    }
    }
