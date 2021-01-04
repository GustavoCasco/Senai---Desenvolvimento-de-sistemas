using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class OrçamentoController : AbstractController
    {
           public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Orçamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}