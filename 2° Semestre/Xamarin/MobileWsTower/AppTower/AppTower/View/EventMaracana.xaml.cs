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
    public partial class EventMaracana : ContentPage
    {
        public EventMaracana()
        {
            InitializeComponent();
            List<Jogo> jogos = new List<Jogo>();
            Jogo jogo = new Jogo();
            jogo.selecaoCasa = "Chile";
            jogo.selecaoVisitante = "Brasil";
            jogo.placarCasa = 0;
            jogo.placarVisitante = 0;

            jogos.Add(jogo);

            jogosList.ItemsSource = jogos;

        }
    }
}