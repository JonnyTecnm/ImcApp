using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImcApp.Views;

                                //Jonathan Alfonso Lara -- 17470063 -- 07-01-2022 -- MS9     

namespace ImcApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
