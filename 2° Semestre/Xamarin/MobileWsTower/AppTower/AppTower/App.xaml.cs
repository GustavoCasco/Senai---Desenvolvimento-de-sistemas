using AppTower.Repository;
using AppTower.View;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTower
{
    public partial class App : Application
    {

       public  static UsuarioRepository database;
        public static UsuarioRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new UsuarioRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuario.db3"));
                }

                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new SplashView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
