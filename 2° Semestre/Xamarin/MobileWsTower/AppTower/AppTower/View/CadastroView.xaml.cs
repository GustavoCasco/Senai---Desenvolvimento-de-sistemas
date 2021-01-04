using AppTower.Model;
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
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }

       private async void btnRegistrar_clicked(object sender, EventArgs e)
        {
            try
            {
                var gravaSenha = SalvaSenha_Toggle.IsToggled;

                if (gravaSenha)
                {
                    if (string.IsNullOrEmpty(txtSenha.Text))
                    {
                        await DisplayAlert("ATENÇÃO", "Informe a senha", "OK");
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    if (txtUsuario.Text.Length >= 4)
                    {
                        await App.Database.SaveUsuarioAsync(new Usuario
                        {
                            User = txtUsuario.Text,
                            Senha = gravaSenha ? txtSenha.Text : "",
                        });

                        txtUsuario.Text = txtSenha.Text = string.Empty;

                        await DisplayAlert("SUCESSO", "Usuário cadastrado com sucesso.", "OK");
                    }
                    else
                    {
                        await DisplayAlert("ATENÇÃO", "O nome do usuáio deve possuir mais de 3 caracteres.", "OK");
                    }

                }
                else
                {
                    await DisplayAlert("ATENÇÃO", "Informe o nome do usuário.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "Ocorreu um erro desconhecido.", "OK");
            }
        }
    }
}