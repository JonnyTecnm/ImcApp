using System;
using Xamarin.Forms;
using ImcApp.Models;
using ImcApp.ViewModels;

                                //Jonathan Alfonso Lara -- 17470063 -- 07-01-2022 -- MS9     

namespace ImcApp.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
            //LimpiarIU();
        }
    }
}
