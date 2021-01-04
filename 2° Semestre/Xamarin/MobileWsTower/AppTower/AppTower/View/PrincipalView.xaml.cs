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
    public partial class PrincipalView : ContentPage
    {
        public PrincipalView()
        {
            InitializeComponent();
            
        }

        private void btncor_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventArenaCorin());
        }

        private void btnpalm_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventAllianz());
        }

        private void btnmar_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventMaracana());
        }

    }
}