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
    public partial class FormPrecMov : ContentPage
    {
        public FormPrecMov()
        {
            InitializeComponent();
        }

        private void Btn_FormPrecMov(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Enpre.Text) && !string.IsNullOrEmpty(movcaba.Text) && !string.IsNullOrEmpty(mobacu.Text) && !string.IsNullOrEmpty(movcano.Text)) 
            {
                DisplayAlert("Formulario smartphone de mejor precio", "Haz confirmado tu recomendacion", "Entendido");
                Navigation.PushAsync(new MenuMo());
            }
            else
            {
                DisplayAlert("Formulario smartphone mejor precio", "Datos incorrectos por favor escriba correctamente los datos", "Entendido");
            }
            
        }
    }
}