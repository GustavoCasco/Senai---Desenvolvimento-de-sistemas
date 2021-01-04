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
    public partial class EventAllianz : ContentPage
    {
        public EventAllianz()
        {
            InitializeComponent();
            List<Jogo> jogos = new List<Jogo>();
            Jogo jogo = new Jogo();
            jogo.selecaoCasa = "Argentina";
            jogo.selecaoVisitante = "Brasil";
            jogo.placarCasa = 0;
            jogo.placarVisitante = 0;

            jogos.Add(jogo);

            jogosList.ItemsSource = jogos;
        }
    }
}