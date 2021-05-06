using ParcialFE100518.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ParcialFE100518.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}