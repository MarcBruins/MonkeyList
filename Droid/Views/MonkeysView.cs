using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MonkeyList.Droid
{
    [Activity]
    public class MonkeysView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MonkeyView);
        }
    }
}
