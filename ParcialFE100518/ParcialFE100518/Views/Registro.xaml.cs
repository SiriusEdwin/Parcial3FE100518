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

        private void Btn_Registro(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EnNameUser.Text) && !string.IsNullOrEmpty(EnEmail.Text) && !string.IsNullOrEmpty(EnContraseña2.Text) && !string.IsNullOrEmpty(EnContra.Text))
            {
                DisplayAlert("Registro", "Haz confirmado tu registro", "ok");
                Navigation.PushAsync(new LoginPage());
            }
            else
            {
                DisplayAlert("Registro", "Datos Incorrectos, por favor coloque correctamente los datos", "ok");
            }
        }
    }
}