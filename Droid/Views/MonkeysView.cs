using Android.App;
using Android.OS;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace MonkeyList.Droid
{
    [Activity(
        Theme = "@style/AppTheme"
    )]
    public class MonkeysView : MvxAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MonkeyView);
        }
    }
}
