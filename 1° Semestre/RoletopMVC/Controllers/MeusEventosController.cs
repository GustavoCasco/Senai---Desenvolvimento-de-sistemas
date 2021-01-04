using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class MeusEventosController : AbstractController
    
    {
      
      EventoRepository eventoRepository = new EventoRepository();
          public IActionResult Aprovado()
       {
           var eaprovado = eventoRepository.ObterEventoPor(1);
           var email = ObterUsuarioSession();
           List<Evento> eventoAproveUser = new List<Evento>();
           foreach (var item in eaprovado)
           {
               if (item.Cliente.Email.Equals(email))
               {
                   eventoAproveUser.Add(item);
               }
           }
            return View (new DashboardViewModel()
            {
                NomeView = "Aprovado",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eaprovado = eventoAproveUser
            });
        }

          public IActionResult Recusado()
       {
           var erecusado = eventoRepository.ObterEventoPor(2);
           var email= ObterUsuarioSession();
           List<Evento> eventoreprovaUser = new List<Evento>();
              foreach (var item in erecusado)
           {
               if (item.Cliente.Email.Equals(email))
               {
                   eventoreprovaUser.Add(item);
               }
           }
            return View (new DashboardViewModel()
            {
                NomeView = "Recusado",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Erecusados = eventoreprovaUser               
            });
        }

          public IActionResult Pendentes()
       {
            var email = ObterUsuarioSession();
            var eventosUsuario = eventoRepository.ObterEventoPor(0);

                List<Evento> eventopendente = new List<Evento>();
              foreach (var item in eventosUsuario)
           {
               if (item.Cliente.Email.Equals(email))
               {
                   eventopendente.Add(item);
               }
           }

            return View (new DashboardViewModel()
            {
                NomeView = "Pendentes",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Ependentes = eventosUsuario
            });
        }
    }
}