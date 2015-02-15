using Android.App;
using Android.Views;
using Android.OS;

namespace AGP1
{
    [Activity(Label = "AGP1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(new GameView(this));
        }
    }
}


