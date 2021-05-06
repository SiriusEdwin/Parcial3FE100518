using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParcialFE100518.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        private async void Btn_Registro(object sender, EventArgs e)
        {
            await DisplayAlert("Registro", "Haz confirmado tu registro", "ok" + Navigation.PushAsync(new AboutPage()));
        }
    }
}