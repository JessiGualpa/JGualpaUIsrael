using JGualpaS2D.Services;
using JGualpaS2D.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JGualpaS2D
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new login());
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
