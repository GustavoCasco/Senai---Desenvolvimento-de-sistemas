using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class QuemSomosController : AbstractController
    {
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "QuemSomos",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}