using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;
using static RoletopMVC.Enum.StatusEventos;

namespace RoletopMVC.Controllers
{
    public class NovosEventosController : AbstractController
    {
             EventoRepository eventosRepository = new EventoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        ServiçosRepository serviçosRepository = new ServiçosRepository();
        
        public IActionResult Index()
        {
            return View (new EventosViewModel()
            {
                NomeView = "Novoevento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                Serviços = serviçosRepository.ObterTodos(),
                 
            });
        }

            [HttpPost]
            
        public IActionResult Registrar(IFormCollection form)
        {
            Evento evento = new Evento();

            var nomeEvento = form["pacote"];
            Serviços serviços = new Serviços(nomeEvento, serviçosRepository.ObterPrecoDe(nomeEvento));
            evento.Serviços = serviços;
            evento.NomeEvento = form["nome"];
            evento.DiadoEvento = DateTime.Parse(form["date"]);
            evento.PrecoTotal = serviçosRepository.ObterPrecoDe(nomeEvento);
            
            Cliente cliente = new Cliente();
            cliente.Nome = ObterUsuarioNomeSession();
            cliente.Telefone = form["telefone"];
            cliente.Email = ObterUsuarioSession();

            evento.Cliente = cliente;
            evento.DataDoPedido = DateTime.Now;
            evento.PrecoTotal = serviçosRepository.ObterPrecoDe(nomeEvento) + 10000;
            evento.TipoEvento = form["event"];

            var urlFoto = $"wwwroot\\{PATH_FOTOSEVENTOS}\\{evento.Cliente.Email}\\{evento.NomeEvento}\\";
            GravarFoto(form.Files, urlFoto);
            evento.Fotodeperfil = urlFoto; 

           

            if (eventosRepository.Inserir(evento))
            {
                return View("Sucesso", new BaseViewModel()
                {
                    NomeView = "Novoevento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new BaseViewModel()
                {
                    NomeView = "Novoevento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public async void GravarFoto(IFormFileCollection arquivos, string urlFoto)
        {
            foreach (var foto in arquivos)
            {
                System.IO.Directory.CreateDirectory(urlFoto).Create();
                var file = System.IO.File.Create(urlFoto + foto.FileName);
                await foto.CopyToAsync(file);
                file.Close();
            }
        }


        public IActionResult Aprovar(ulong id)
        {
            var evento = eventosRepository.ObterPor(id);
            evento.Status = (uint)StatusPedido.APROVADO;

            if (eventosRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");

            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possivel aprovar seu pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }


        }

        public IActionResult Reprovar(ulong id)
        {
            var evento = eventosRepository.ObterPor(id);
            evento.Status = (uint)StatusPedido.RECUSADO;

            if (eventosRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Administrador");

            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possivel reprovar seu pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
}
}