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
    public partial class MenuMo : ContentPage
    {
        public MenuMo()
        {
            InitializeComponent();
        }

        private void Btn_FormSmart(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormSmartFav());
        }

        private void Btn_FormSmartSpec(object sender, EventArgs e)
        {  
            Navigation.PushAsync(new FormSpecSmart());
        }

        private void Btn_FormPrecMov(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormPrecMov());
        }

        private void Btn_salir(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

    }
}