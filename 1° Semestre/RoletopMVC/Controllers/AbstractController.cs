using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email";
        protected const string SESSION_CLIENTE_NOME = "cliente_nome";
        protected const string SESSION_CLIENTE_TIPO = "cliente_tipo";
        protected const string PATH_FOTOSEVENTOS = "fotoevento\\fotos";
        
        protected string ObterUsuarioSession()
        {
            var usuario = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty(usuario))
            {
                return usuario;
            }else
            {
                return "";
            }
        }
        protected string ObterUsuarioNomeSession()
        {
            var nomeUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                return nomeUsuario;
            }else
            {
                return "";
            }
        }

          protected string ObterUsuarioTipoSession()
        {
            var tipoUsuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(tipoUsuario))
            {
                return tipoUsuario;
            }else
            {
                return "";
            }
        }
    }
}