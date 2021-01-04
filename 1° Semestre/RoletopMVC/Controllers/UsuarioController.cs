using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class UsuarioController : AbstractController
    {
        public IActionResult Index()
       {
            return View (new BaseViewModel()
            {
                NomeView = "Usuario",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}