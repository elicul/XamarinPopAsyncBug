using System;
using Xamarin.Forms;

namespace XamarinPopAsyncBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(FirstPage));
        }
    }
}