using Android.Content;
using Android.Content.Res;
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

        public ColorStateList PlaceholderColorList
        {
            get
            {
                int[][] states = new int[][]
                {
                    new int[] { Android.Resource.Attribute.StateEnabled},   // enabled
                    new int[] {-Android.Resource.Attribute.StateEnabled},   // disabled
                    new int[] {-Android.Resource.Attribute.StateChecked},   // unchecked
                    new int[] { Android.Resource.Attribute.StateChecked }   // pressed
                };

                int[] colors = new int[]
                {
                    Xamarin.Forms.Color.Black.ToAndroid(),
                    Xamarin.Forms.Color.Red.ToAndroid(),
                    Xamarin.Forms.Color.Green.ToAndroid(),
                    Xamarin.Forms.Color.Blue.ToAndroid(),
                };

                return new ColorStateList(states, colors);
            }
        }

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

        protected override void UpdateColor()
        {
            return;
        }

        protected override void UpdateBackgroundColor()
        {
            return;
        }

        protected override void UpdatePlaceholderColor()
        {
            return;
        }
    }
}