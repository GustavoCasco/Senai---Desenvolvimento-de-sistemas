using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enum;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class EventosController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Index()
        {
            var eventosPub = eventoRepository.ObterPrivacidade(1);
            foreach (var item in eventosPub)
            {
                var urlFoto = Directory.GetFiles(item.Fotodeperfil).FirstOrDefault();
                var urlRelativa = urlFoto.Replace(Directory.GetCurrentDirectory(), "").Replace("\\", "/").Replace("wwwroot", "");
                item.Fotodeperfil = urlRelativa;
            }
            return View(new EventosViewModel()
            {
                NomeView = "Eventos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Eventos = eventosPub
            });
        }

        public IActionResult AtulizarEvento(IFormCollection form)
        {
            var idEvento = ulong.Parse(form["id"]);

            var evento = eventoRepository.ObterPor(idEvento);
            evento.Privacidade = (uint)PrivacidadeEvento.Publico;

            var atualizarEvento = eventoRepository.Atualizar(evento);
            if (atualizarEvento)
            {
                return RedirectToAction("Index", "Eventos");
            }
            else
            {
                return View("Erro", new EventosViewModel()
                {
                    NomeView = "Eventos",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}