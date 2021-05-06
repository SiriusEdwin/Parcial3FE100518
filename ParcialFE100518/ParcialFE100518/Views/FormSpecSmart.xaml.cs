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
    public partial class FormSpecSmart : ContentPage
    {
        public FormSpecSmart()
        {
            InitializeComponent();
        }

        private void Btn_FormSpecSmart(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cumemo.Text) && !string.IsNullOrEmpty(curam.Text) && !string.IsNullOrEmpty(cunu.Text) && !string.IsNullOrEmpty(cumega.Text) && !string.IsNullOrEmpty(cutextam.Text))
            {
                DisplayAlert("Formulario smartphone favorito", "Haz confirmado tu recomendacion", "Entendido");
                Navigation.PushAsync(new MenuMo());
            }
            else
            {
                DisplayAlert("Formulario smartphone favorito", "Datos incorrectos por favor escriba correctamente los datos", "Entendido");
            }
        }

       
    }
}