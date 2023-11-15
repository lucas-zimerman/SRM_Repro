using System;
using Sentry;
using SRM_Repro2.Services;
using SRM_Repro2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SRM_Repro2
{
    public partial class App : Application
    {

        public App()
        {
            SRM_LIB.SentryLib.Init();
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
