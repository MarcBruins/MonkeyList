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
	[Register ("MonkeyView")]
	partial class MonkeysView
	{
		[Outlet]
		UIKit.UITableView MonkeyTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MonkeyTableView != null) {
				MonkeyTableView.Dispose ();
				MonkeyTableView = null;
			}
		}
	}
}
