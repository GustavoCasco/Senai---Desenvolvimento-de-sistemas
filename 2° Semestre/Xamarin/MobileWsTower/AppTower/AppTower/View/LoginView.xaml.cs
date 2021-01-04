using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTower.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            var user = txtUsuario.Text ?? "";

            var usuarios = await App.Database.GetUsuarioAsync();

            var usuario = usuarios.Where(p => p.User == user && p.Senha != "").FirstOrDefault();

            if (usuario != null)
            {
            App.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
            await DisplayAlert("", "Usuario não encontrado", "OK");
                    
            }

        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }

        private async void User_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var user = txtUsuario.Text ?? "";

                if (!string.IsNullOrEmpty(user) && user.Length >= 4)
                {
                    var usuarios = await App.Database.GetUsuarioAsync();

                    var usuario = usuarios.Where(p => p.User == user && p.Senha != "").FirstOrDefault();

                    if (usuario != null)
                    {
                        var result = await DisplayAlert("", "Existe uma senha salva para esse usuário, deseja usar esta senha?", "SIM", "NÃO");

                        if (result)
                        {
                            txtSenha.Text = usuario.Senha;
                            txtSenha.IsPassword = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}