
using Android.App;
using Android.Content.PM;
using Android.OS;
using FFImageLoading.Forms.Platform;
using Xamarin.Forms;
using PanCardView.Droid;
using PanCardViewSample.Views;

namespace PanCardViewSample.Droid
{
	[Activity(Label = "PanCardViewSample.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
            //allowing the device to change the screen orientation based on the rotation 
            MessagingCenter.Subscribe<HappinessTools>(this, "AllowLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            //during page close setting back to portrait
            MessagingCenter.Subscribe<HappinessTools>(this, "PreventLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });

            //allowing the device to change the screen orientation based on the rotation 
            MessagingCenter.Subscribe<TipsToHappyClassroom>(this, "AllowLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            //during page close setting back to portrait
            MessagingCenter.Subscribe<TipsToHappyClassroom>(this, "PreventLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });


            MessagingCenter.Subscribe<CarouselSampleXamlView>(this, "AllowLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            //during page close setting back to portrait
            MessagingCenter.Subscribe<CarouselSampleXamlView>(this, "PreventLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });


            TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			Forms.SetFlags("FastRenderers_Experimental");
			global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init(true);
            CardsViewRenderer.Preserve();

            LoadApplication(new App());
		}

        
	}
}