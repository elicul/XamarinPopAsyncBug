﻿using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPopAsyncBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Shell.Current.Navigation.PopAsync();
            return true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"{nameof(FirstPage)}/{nameof(SecondPage)}");
        }
    }
}