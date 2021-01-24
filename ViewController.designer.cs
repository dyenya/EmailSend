// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;


namespace MailingSolution
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSComboBox ComboBox { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell fldBody { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell fldFrom { get; set; }

		[Outlet]
		AppKit.NSSecureTextFieldCell fldPassword { get; set; }

		[Outlet]
		AppKit.NSTextField fldStatus { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell fldSubject { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell fldTo { get; set; }

		[Outlet]
		AppKit.NSComboBoxCell TemplateValue { get; set; }

		[Action ("btnAdd:")]
		partial void btnAdd (Foundation.NSObject sender);

		[Action ("btnDelete:")]
		partial void btnDelete (AppKit.NSButtonCell sender);

		[Action ("btnIncrement:")]
		partial void btnIncrement (AppKit.NSButtonCell sender);

		[Action ("btnSend:")]
		partial void btnSend (AppKit.NSButtonCell sender);

		[Action ("TemplateChoose:")]
		partial void TemplateChoose (AppKit.NSComboBoxCell sender);
		
		

		void ReleaseDesignerOutlets ()
		{
			if (ComboBox != null) {
				ComboBox.Dispose ();
				ComboBox = null;
			}

			if (fldBody != null) {
				fldBody.Dispose ();
				fldBody = null;
			}

			if (fldFrom != null) {
				fldFrom.Dispose ();
				fldFrom = null;
			}

			if (fldPassword != null) {
				fldPassword.Dispose ();
				fldPassword = null;
			}

			if (fldStatus != null) {
				fldStatus.Dispose ();
				fldStatus = null;
			}

			if (fldSubject != null) {
				fldSubject.Dispose ();
				fldSubject = null;
			}

			if (fldTo != null) {
				fldTo.Dispose ();
				fldTo = null;
			}

			if (TemplateValue != null) {
				TemplateValue.Dispose ();
				TemplateValue = null;
			}
			
			

		}
	}
}
