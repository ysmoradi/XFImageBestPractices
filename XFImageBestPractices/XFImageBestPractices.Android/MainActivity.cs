using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.Android;

[assembly: Preserve]

namespace XFImageBestPractices.Droid
{
    [Activity(Label = "XFImageBestPractices", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Android.Glide.Forms.Init(this); // #BP To configure glidex.forms

            LoadApplication(new App());
        }
    }
}