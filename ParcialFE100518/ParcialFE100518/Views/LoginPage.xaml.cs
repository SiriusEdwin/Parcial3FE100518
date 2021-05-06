﻿using ParcialFE100518.ViewModels;
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

        private async void Btn_APPregistro(object sender, EventArgs e)
        {
            await DisplayAlert("Resgitro", "Haz sido registrado correctamente", "Ok" + Navigation.PushAsync(new AboutPage()));
        }
    }
}