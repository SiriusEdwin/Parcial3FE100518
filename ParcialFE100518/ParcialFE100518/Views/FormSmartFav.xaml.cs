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
    public partial class FormSmartFav : ContentPage
    {
        public FormSmartFav()
        {
            InitializeComponent();
        }
        private void Btn_FormSmart(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EnMo.Text) && !string.IsNullOrEmpty(Ensis.Text) && !string.IsNullOrEmpty(Encom.Text) && !string.IsNullOrEmpty(Encam.Text) && !string.IsNullOrEmpty(Enca.Text)) 
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