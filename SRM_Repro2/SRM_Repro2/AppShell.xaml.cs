using System;
using System.Collections.Generic;
using Sentry;
using SRM_Repro2.ViewModels;
using SRM_Repro2.Views;
using Xamarin.Forms;

namespace SRM_Repro2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            SRM_LIB.SentryLib.HelloWorld();
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
