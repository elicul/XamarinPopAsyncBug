using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPopAsyncBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        private readonly Dictionary<string, Type> routes = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            routes.Add(nameof(FirstPage), typeof(FirstPage));
            routes.Add($"{nameof(FirstPage)}/{nameof(SecondPage)}", typeof(SecondPage));
            routes.Add($"{nameof(FirstPage)}/{nameof(SecondPage)}/{nameof(ThirdPage)}", typeof(ThirdPage));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}