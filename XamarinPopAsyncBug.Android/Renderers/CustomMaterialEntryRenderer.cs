using Android.Content;
using Google.Android.Material.TextField;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;
using XamarinPopAsyncBug;
using XamarinPopAsyncBug.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustomMaterialEntry), typeof(CustomMaterialEntryRenderer), new[] { typeof(VisualMarker.MaterialVisual) })]

namespace XamarinPopAsyncBug.Droid.Renderers
{
    public class CustomMaterialEntryRenderer : MaterialEntryRenderer
    {
        private CustomMaterialEntry _customMaterialEntry;
        private Context _context;

        public CustomMaterialEntryRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            _customMaterialEntry = (CustomMaterialEntry)Element;
            Control.HintEnabled = true;
            Control.HelperTextEnabled = true;
            Control.SetBoxCornerRadii(10f, 10f, 10f, 10f);
            Control.BoxBackgroundMode = TextInputLayout.BoxBackgroundOutline;
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}