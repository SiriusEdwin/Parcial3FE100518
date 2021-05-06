using ParcialFE100518.Services;
using ParcialFE100518.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParcialFE100518
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new AboutPage());
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
