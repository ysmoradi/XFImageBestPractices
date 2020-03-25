using FFImageLoading.Forms.Platform;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace XFImageBestPractices.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();

            CachedImageRenderer.InitImageSourceHandler();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
