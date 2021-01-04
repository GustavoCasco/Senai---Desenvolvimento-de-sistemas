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
    public partial class SplashView : ContentPage
    {
        public SplashView()
        {
            InitializeComponent();
            navegacao();
        }

        private async void navegacao()
        {
            await Task.Delay(3000);

            App.Current.MainPage = new NavigationPage(new LoginView());
        }

        async void CompositeButton_Clicked(object sender, EventArgs e)
        {
            await Task.WhenAll(
                Image.RotateTo(1080, 6000),
                Image.FadeTo(0, 6000));

        }
    }
}