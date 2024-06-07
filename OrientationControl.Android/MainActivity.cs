using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using OrientationControl.Droid;
using OrientationControl.Interface;
using Xamarin.Forms;

[assembly: Dependency(typeof(DroidImplementation))]
namespace OrientationControl.Droid
{
    public class DroidImplementation : ITestInterface
    {
        public void EnableRotation()
        {
            ((Activity)Forms.Context).RequestedOrientation = Android.Content.PM.ScreenOrientation.Sensor;
        }
        public void DisableRotation()
        {
            ((Activity)Forms.Context).RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
        }
    }
    [Activity(Label = "OrientationControl",ScreenOrientation = ScreenOrientation.Portrait, Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}