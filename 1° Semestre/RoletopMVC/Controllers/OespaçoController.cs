using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
     public class OespaçoController : AbstractController
    {
        public IActionResult Index()
        {
            return View (new BaseViewModel()
            {
                NomeView = "Oespaço",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
}
}