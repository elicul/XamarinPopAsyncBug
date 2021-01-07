using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPopAsyncBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Shell.Current.Navigation.PopAsync();
            // Work around
            //Shell.Current.Navigation.RemovePage(Shell.Current.Navigation.NavigationStack.LastOrDefault());
            return true;
        }
    }
}