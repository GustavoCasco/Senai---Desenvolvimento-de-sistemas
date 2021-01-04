using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enum;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;
using static RoletopMVC.Enum.StatusEventos;

namespace RoletopMVC.Controllers
{
        public class AdministradorController : AbstractController
    {
      EventoRepository eventoRepository = new EventoRepository();  
      ServiçosRepository serviçosRepository = new ServiçosRepository();  
      
        public IActionResult Dashboard()
        {
            var ninguemlogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if(!ninguemlogado && (uint)TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {

            var eventos = eventoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            foreach (var item in eventos)
            {
                switch (item.Status)
                {
                    case (uint) StatusPedido.APROVADO:
                    dashboardViewModel.EventosAprovados++;
                    break;

                    case (uint) StatusPedido.RECUSADO:
                    dashboardViewModel.EventosReprovados++;
                    break;

                    default:
                    dashboardViewModel.EventosPendentes++;
                    dashboardViewModel.Evento.Add(item);
                    break;
                   
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            dashboardViewModel.UsuarioNome = ObterUsuarioNomeSession();
        
            
            return View(dashboardViewModel);
            }else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem acesso ao dashboard"
                });
            }
        }

         public IActionResult Eaprovado()
        {
            
             var ninguemlogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if(!ninguemlogado && (uint)TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {

            var eventos = eventoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

               foreach (var item in eventos)
            {
                switch (item.Status)
                {
                    case (uint) StatusPedido.PENDENTE:
                    dashboardViewModel.EventosPendentes++;
                    break;

                    case (uint) StatusPedido.RECUSADO:
                    dashboardViewModel.EventosReprovados++;
                    break;

                    default:
                    dashboardViewModel.EventosAprovados++;
                    dashboardViewModel.Evento.Add(item);
                    break;
                   
                }
            }
            dashboardViewModel.NomeView = "Eaprovado";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            dashboardViewModel.UsuarioNome = ObterUsuarioNomeSession();
        
            
            return View(dashboardViewModel);
            }else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem acesso ao dashboard"
                });
            }
        }
        public IActionResult Ereprovado()
        {
             var ninguemlogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if(!ninguemlogado && (uint)TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {

            var eventos = eventoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

               foreach (var item in eventos)
            {
                switch (item.Status)
                {
                    case (uint) StatusPedido.APROVADO:
                    dashboardViewModel.EventosAprovados++;
                    break;

                    case (uint) StatusPedido.PENDENTE:
                    dashboardViewModel.EventosPendentes++;
                    break;

                    default:
                    dashboardViewModel.EventosReprovados++;
                    dashboardViewModel.Evento.Add(item);
                    break;
                   
                }
            }
            dashboardViewModel.NomeView = "Ereprovado";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            dashboardViewModel.UsuarioNome = ObterUsuarioNomeSession();
        
            
            return View(dashboardViewModel);
            }else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem acesso ao dashboard"
                });
            }
        }
    }
}
