using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFilmes.ViewModels
{
    public class LoginViewModel
    {
        // Define que a propriedade Email é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        public string Email { get; set; }

        // Define que a propriedade Senha é obrigatória
        // Caso não seja informada, exibe a mensagem de erro
        [Required(ErrorMessage = "Informe a senha do usuário!")]
        public string Senha { get; set; }
    }
}
