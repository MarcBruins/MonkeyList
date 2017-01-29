using System;
using MonkeyList.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace MonkeyList.Core.iOS
{
    public partial class MonkeyView : MvxViewController<MonkeysViewModel>
    {
        public MonkeyView() : base("MonkeyView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

            var source = new MvxSimpleTableViewSource(MonkeyTableView, MonkeyCell.Key, MonkeyCell.Key);
            MonkeyTableView.RowHeight = 130;

            var set = this.CreateBindingSet<MonkeyView, MonkeysViewModel>();
            set.Bind(source).To(vm => vm.Monkeys);
            set.Apply();

            MonkeyTableView.Source = source;
            MonkeyTableView.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

