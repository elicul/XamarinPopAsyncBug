using Xamarin.Forms;

namespace XamarinPopAsyncBug
{
    public class CustomMaterialEntry : Entry
    {
        public static readonly BindableProperty HasErrorProperty =
  BindableProperty.Create(nameof(HasError), typeof(bool), typeof(CustomMaterialEntry), false);

        public bool HasError
        {
            get { return (bool)GetValue(HasErrorProperty); }
            set { SetValue(HasErrorProperty, value); }
        }

        public static readonly BindableProperty ErrorTextProperty =
  BindableProperty.Create(nameof(ErrorText), typeof(string), typeof(CustomMaterialEntry), string.Empty);

        public string ErrorText
        {
            get { return (string)GetValue(ErrorTextProperty); }
            set { SetValue(ErrorTextProperty, value); }
        }
    }
}