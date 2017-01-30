using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MonkeyList.Core.iOS
{
    public partial class MonkeyCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("MonkeyCell");
        public static readonly UINib Nib;

        static MonkeyCell()
        {
            Nib = UINib.FromName("MonkeyCell", NSBundle.MainBundle);
        }

        protected MonkeyCell(IntPtr handle) : base(handle)
        {

            var imageViewLoader = new MvxImageViewLoader(() => monkeyImage);

            // Note: this .ctor should not contain any initialization logic.
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<MonkeyCell, Monkey>();
                set.Bind(imageViewLoader).To(m => m.Image);
                set.Bind(nameLabel).To(m => m.Name);
                set.Bind(originLabel).To(m => m.Location);
                set.Bind(descriptionLabel).To(m => m.Details);
                set.Apply();
            });
        }
    }
}
