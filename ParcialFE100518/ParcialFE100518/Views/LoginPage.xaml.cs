using ParcialFE100518.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void Btn_APPregistro(object sender, EventArgs e)
        {
            DisplayAlert("Registro", "Empieza a crear  tu cuenta", "ok");
            Navigation.PushAsync(new Registro());
        }


        private void Btn_APPMenu(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Email.Text) && !string.IsNullOrEmpty(Contra.Text))
            {
                DisplayAlert("Menu", "Bienvenido al menu puedes comenzar a explorar", "Entendido");
                Navigation.PushAsync(new MenuMo());
            }
            else
            {
                DisplayAlert("Login", "Datos incorrectos por favor escriba correctamente los datos", "Entendido");
            }
            
        }

    }
}