using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enum;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
         public class CadastroController : AbstractController {
        ClienteRepository clienteRepository = new ClienteRepository ();
        public IActionResult Index () {
            return View (new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            try {
                Cliente cliente = new Cliente (form["nome"],  form["senha"], form["email"], form["telefone"], form["cpf"], DateTime.Parse (form["data_nascimento"]));
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                clienteRepository.Inserir (cliente);
                return View ("sucessodelogin", new RespostaViewModel(){

                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession(),
                });

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel(){

                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession(),
                });
            }

        }
    }
}