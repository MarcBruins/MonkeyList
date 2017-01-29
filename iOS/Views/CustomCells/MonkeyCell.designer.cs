// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MonkeyList.Core.iOS
{
	[Register ("MonkeyCell")]
	partial class MonkeyCell
	{
		[Outlet]
		UIKit.UILabel descriptionLabel { get; set; }

		[Outlet]
		UIKit.UIImageView monkeyImage { get; set; }

		[Outlet]
		UIKit.UILabel nameLabel { get; set; }

		[Outlet]
		UIKit.UILabel originLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (descriptionLabel != null) {
				descriptionLabel.Dispose ();
				descriptionLabel = null;
			}

			if (nameLabel != null) {
				nameLabel.Dispose ();
				nameLabel = null;
			}

			if (originLabel != null) {
				originLabel.Dispose ();
				originLabel = null;
			}

			if (monkeyImage != null) {
				monkeyImage.Dispose ();
				monkeyImage = null;
			}
		}
	}
}
