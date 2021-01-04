using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
        public class GaleriaController : AbstractController
    {
        public IActionResult Index()
       {
            return View (new BaseViewModel()
            {
                NomeView = "Galeria",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Baile()
       {
            return View (new BaseViewModel()
            {
                NomeView = "Baile",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Rave()
      {
            return View (new BaseViewModel()
            {
                NomeView = "Rave",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Casamento()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Casamento",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

}
}