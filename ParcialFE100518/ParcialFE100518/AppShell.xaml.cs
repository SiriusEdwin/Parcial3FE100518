using ParcialFE100518.ViewModels;
using ParcialFE100518.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ParcialFE100518
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
