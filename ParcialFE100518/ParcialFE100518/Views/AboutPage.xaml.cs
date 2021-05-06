using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParcialFE100518.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnButtonClicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}